namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Типы возможных продуктов.
/// </summary>
public enum TypeProduct
{
    /// <summary>
    /// Самые обычные продукты
    /// </summary>
    Ordinary = 0,

    /// <summary>
    /// Залоговые продукты
    /// </summary>
    Deposit = 1,

    /// <summary>
    /// Продукты для индивидуальных предпринимателей
    /// </summary>
    Business = 2,

    /// <summary>
    /// Продукты для рефинансирования
    /// </summary>
    Refinancing = 3
}
