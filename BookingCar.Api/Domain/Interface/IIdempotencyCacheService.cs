namespace BookingCar.Api.Domain.Interface;

/// <summary>
/// Интерфейс по обработке идемпотентности.
/// </summary>
public interface IIdempotencyCacheService
{
    /// <summary>
    /// Получить данные из кэша по ключу идемпотентности.
    /// </summary>
    /// <param name="idempotencyKey">ключ идемпотентности.</param>
    /// <returns>Ответ который был по запросу.</returns>
    IdempotentResponse GetAsync(string idempotencyKey);

    /// <summary>
    /// Сохраним данные по ключу идемпотентности.
    /// </summary>
    /// <param name="idempotencyKey">ключ идемпотентности.</param>
    /// <param name="cachedResponse">модель с данными для сохранения.</param>
    /// <param name="requestStorageTimeForMinutes">время на которое необходимо сохранить данные.</param>
    void SetAsync(string idempotencyKey, IdempotentResponse cachedResponse, TimeSpan requestStorageTimeForMinutes);
}
