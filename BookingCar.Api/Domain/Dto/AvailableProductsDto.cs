namespace BookingCar.Api.Domain.Dto;

/// <summary>
/// Модель данных для получения доступных продуктов. <br />
/// Может использоваться когда еще нет заявки.
/// </summary>
public class AvailableProductsDto
{
    /// <summary>
    /// Клиент который подписывает займ.
    /// </summary>
    /// <remarks>Можно не передавать, тогда возврат будет общим.</remarks>
    public int ClientId { get; set; }

    /// <summary>
    /// Нужно ли искать активную заявку.
    /// </summary>
    public bool IsLoan { get; set; }

    /// <summary>
    /// Тип продуктов.
    /// </summary>
    [EnumValidator(typeof(TypeProduct))]
    public TypeProduct Type { get; set; }

    /// <summary>
    /// Показывать ли только кредитные линии.
    /// </summary>
    public bool IsOnlyCreditLines { get; set; }
}
