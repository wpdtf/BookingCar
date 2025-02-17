namespace BookingCar.Api.Domain.Entities.Step207;

/// <summary>
/// Модель данных для хранения информации по договору залога.
/// </summary>
public class DepositAgreement
{
    /// <summary>
    /// Общая информация по договору. <br />
    /// О клиенте, условиях займа, о всяком.
    /// </summary>
    public List<LoanInfoForDepositAndGuarantee> LoanDepositInfo { get; set; }

    /// <summary>
    /// Информация о залоге, т.е об автомобиле который берем в залог.
    /// </summary>
    public List<DepositInfo> DepositInfo { get; set; }

    /// <summary>
    /// Информация о залогодателе, т.е о нас как об организации.
    /// </summary>
    public List<PledgerInfo> PledgerInfo { get; set; }
}

public class DepositInfo
{
    [JsonPropertyName("TSVIN")]
    public string AutomobileVin { get; set; }

    [JsonPropertyName("TSMarka")]
    public string AutomobileMarka { get; set; }

    [JsonPropertyName("TSKateg")]
    public string AutomobileCategory { get; set; }

    [JsonPropertyName("TSGodV")]
    public int AutomobileProductionDate { get; set; }

    [JsonPropertyName("TSNomDvig")]
    public string AutomobileEngineNomer { get; set; }

    [JsonPropertyName("TSNomRam")]
    public string AutomobileFrameNomer { get; set; }

    [JsonPropertyName("TSNomKuz")]
    public string AutomobileBodyNomer { get; set; }

    [JsonPropertyName("TSColor")]
    public string AutomobileColor { get; set; }

    [JsonPropertyName("PTSKem")]
    public string AutomobilePtsIssuedBy { get; set; }

    [JsonPropertyName("PTSSN")]
    public string AutomobilePtsSerial { get; set; }

    [JsonPropertyName("PTSKogda")]
    public string AutomobilePtsDateIssued { get; set; }

    [JsonPropertyName("TSRegZnak")]
    public string AutomobileRegistrazionNumber { get; set; }

    [JsonPropertyName("KadastrS")]
    public string AutomobileKadastrAmount { get; set; }

    [JsonPropertyName("KadastrSTxt")]
    public string AutomobileKadastrAmountText { get; set; }
}
