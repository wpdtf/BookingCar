namespace BookingCar.Api.Domain.Entities.Step232;

/// <summary>
/// Модель для хранения информации по одобренным продуктам.
/// </summary>
public class AvailableProducts
{
    /// <summary>
    /// Наименование продукта.
    /// </summary>
    [JsonPropertyName("name")]
    public string NameT { get; set; }

    /// <summary>
    /// Период платежей.
    /// </summary>
    [JsonPropertyName("periods")]
    public string PeriodPay { get; set; }

    /// <summary>
    /// Минимальная сумма доступная для продукта.
    /// </summary>
    public double MinSum { get; set; }

    /// <summary>
    /// Максимальная сумма доступная для продукта.
    /// </summary>
    [JsonPropertyName("maxSum")]
    public double SumCred { get; set; }

    /// <summary>
    /// Процентная ставка по займу.
    /// </summary>
    [JsonPropertyName("percent")]
    public string Proc { get; set; }

    /// <summary>
    /// Ключ условия продукта.
    /// </summary>
    /// <remarks>
    /// Сам по себе продукт ориентируется максимальной и минимальной суммой, конечные условия определяются по данному ключу.
    /// </remarks>
    public int KeyTL { get; set; }

    /// <summary>
    /// Ключ продукта.
    /// </summary>
    public int KeyDZT { get; set; }

    /// <summary>
    /// Период платежей.
    /// </summary>
    [JsonPropertyName("paymentPeriod")]
    public int PerVip { get; set; }

    /// <summary>
    /// Доступность онлайна. <br />
    /// По идее всегда доступен будет.
    /// </summary>
    [JsonPropertyName("isOnline")]
    public int AllowOnline { get; set; }

    /// <summary>
    /// Тип периода оплаты.
    /// </summary>
    /// <remarks>
    /// 0 - один платеж, 1 - платежи с периодичностью до месяца, 2 - ежемесячные платежи.
    /// </remarks>
    [JsonPropertyName("calculationType")]
    public short Vr { get; set; }

    /// <summary>
    /// Доступность онлайна не верифицированному клиенту.
    /// </summary>
    [JsonPropertyName("forNotVerified")]
    public int ForOnline_notVerified { get; set; }

    /// <summary>
    /// Для процентных периодов в строку.
    /// </summary>
    [JsonPropertyName("percentForPeriods")]
    public string PrcPeriod { get; set; }

    /// <summary>
    /// Продукты не требующие одобрения контактов. <br />
    /// Линейка БВО.
    /// </summary>
    [JsonPropertyName("isBVO")]
    public short NotNeedContact { get; set; }

    /// <summary>
    /// Максимальная сумма по условию.
    /// </summary>
    [JsonPropertyName("maxSumByTariff")]
    public double MaxSumBykeyTL { get; set; }

    /// <summary>
    /// Имеется ли выбор дат платежей.
    /// </summary>
    [JsonPropertyName("canSetDatePays")]
    public short UseListDatPlat { get; set; }

    /// <summary>
    /// Оплата основного долга в конце срока.
    /// </summary>
    [JsonPropertyName("MainDebtAtEndTerm")]
    public int ODAtEnd { get; set; }
}
