namespace BookingCar.Api.Domain.Helpers;

/// <summary>
/// Сервис по работе с кэшем для поддержки работы идемпотентности.
/// </summary>
public class IdempotencyCacheService : IIdempotencyCacheService
{
    private readonly IMemoryCache _memoryCache;

    public IdempotencyCacheService(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public IdempotentResponse GetAsync(string idempotencyKey)
    {
        _memoryCache.TryGetValue(idempotencyKey, out IdempotentResponse cachedResponse);
        return cachedResponse;
    }

    public void SetAsync(string idempotencyKey, IdempotentResponse cachedResponse, TimeSpan requestStorageTimeForMinutes)
    {
        _memoryCache.Set(idempotencyKey, cachedResponse, requestStorageTimeForMinutes);
    }
}
