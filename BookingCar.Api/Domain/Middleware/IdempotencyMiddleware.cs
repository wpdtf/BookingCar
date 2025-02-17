namespace BookingCar.Api.Domain.Middleware;

/// <summary>
/// Мидлваре по обработке логики идемпотентности.
/// </summary>
public class IdempotencyMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IIdempotencyCacheService _idempotencyCacheService;
    private readonly int _requestStorageTimeForMinutes;

    public IdempotencyMiddleware(RequestDelegate next, IIdempotencyCacheService idempotencyCacheService, IOptions<AppSettings> options)
    {
        _next = next;
        _idempotencyCacheService = idempotencyCacheService;
        _requestStorageTimeForMinutes = options.Value.RequestStorageTimeForMinutes;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var idempotencyKey = context.Request.Headers["Idempotency-Key"].FirstOrDefault();

        if (!string.IsNullOrEmpty(idempotencyKey))
        {
            var existingResponse = _idempotencyCacheService.GetAsync(idempotencyKey);
            if (existingResponse != null)
            {
                context.Response.StatusCode = existingResponse.StatusCode;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(existingResponse.Content);
                return;
            }

            var originalBodyStream = context.Response.Body;

            using var memoryStream = new MemoryStream();
            context.Response.Body = memoryStream;

            await _next(context);

            memoryStream.Seek(0, SeekOrigin.Begin);
            var idempotentResponse = new IdempotentResponse
            {
                StatusCode = context.Response.StatusCode,
                Content = await new StreamReader(memoryStream).ReadToEndAsync()
            };

            _idempotencyCacheService.SetAsync(idempotencyKey, idempotentResponse, TimeSpan.FromMinutes(_requestStorageTimeForMinutes));

            memoryStream.Seek(0, SeekOrigin.Begin);
            await memoryStream.CopyToAsync(originalBodyStream);
        }

    }
}
