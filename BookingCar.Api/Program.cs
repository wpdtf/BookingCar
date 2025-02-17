using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Data.SqlClient;

namespace BookingCar.Api;

internal static class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOptionsWithValidateOnStart<AppSettings>().Bind(builder.Configuration).ValidateDataAnnotations();
        var configuration = builder.Configuration.Get<AppSettings>();

        builder.Services.AddDbContext<GeneralRepository>(x =>
            x.UseSqlServer(configuration.ConnectionStrings.MsSqlConnection), ServiceLifetime.Singleton);
        builder.Services.AddDbContext<BookingRepository>(x =>
            x.UseSqlServer(configuration.ConnectionStrings.MsSqlConnection), ServiceLifetime.Singleton);

        builder.Services.AddHttpLogging(x => x.LoggingFields = HttpLoggingFields.ResponseBody | HttpLoggingFields.RequestBody |
            HttpLoggingFields.RequestProperties | HttpLoggingFields.ResponseStatusCode);

        builder.Services.AddControllers(options => options.SuppressAsyncSuffixInActionNames = true).AddJsonOptions(x =>
        {
            x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            x.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });
        builder.Services.AddSwaggerGen(options =>
        {
            options.CustomOperationIds(e => $"{Regex.Replace(e.RelativePath, "{|}", "")}{e.HttpMethod}");
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = typeof(Program).Assembly.GetName().Name,
                Version = "v1",
            });
            var xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
            xmlFiles.ForEach(xmlFile => options.IncludeXmlComments(xmlFile));
        });

        builder.Services.AddProblemDetails(options => options.CustomizeProblemDetails = (context) =>
        {
            var ex = context.HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            int code = -1;
            if (ex is SqlException sqlException)
            {
                context.ProblemDetails.Detail = ex.Message;
            }

            context.ProblemDetails.Extensions["errorCode"] = code;
        });

        builder.Services.AddMemoryCache();
        builder.Services.AddSingleton<IIdempotencyCacheService, IdempotencyCacheService>();

        builder.Services.AddScoped<IGeneralRepository, GeneralRepository>();
        builder.Services.AddScoped<IBookingRepository, BookingRepository>();

        builder.Services.AddResponseCaching();

        var app = builder.Build();

        var cultureInfo = new CultureInfo("en-US");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

        if (app.Environment.IsProduction() is false)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseMiddleware<IdempotencyMiddleware>();
        app.UseResponseCaching();

        app.UseHttpLogging();
        _ = app.Environment.IsProduction() is false
            ? app.UseDeveloperExceptionPage()
            : app.UseExceptionHandler();

        app.UseStatusCodePages();

        app.MapControllers();

        app.Run();
    }
}
