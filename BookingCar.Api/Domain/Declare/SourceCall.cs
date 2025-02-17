namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Источники вызова эндпоинта, тип устройства через которое клиент оформляет заем.
/// </summary>
public enum SourceCall
{
    /// <summary>
    /// Сайт компании.
    /// </summary>
    Website = -1,

    /// <summary>
    /// Мобильное приложение.
    /// </summary>
    Phone = -4
}
