namespace BookingCar.Api.Domain.Entities.Step207;

/// <summary>
/// Модель данных для хранения информации по договору поручительства.
/// </summary>
public class GuaranteeAgreement
{
    /// <summary>
    /// Общая информация по договору. <br />
    /// О клиенте, условиях займа, о всяком.
    /// </summary>
    public List<LoanInfoForDepositAndGuarantee> LoanGuaranteeInfo { get; set; }

    /// <summary>
    /// Информация о поручителе, у нас это Гарант С.
    /// </summary>
    public List<GuaranteeInfo> GuaranteeInfo { get; set; }

    /// <summary>
    /// Информация о залогодателе, т.е о нас как об организации.
    /// </summary>
    public List<PledgerInfo> PledgerInfo { get; set; }
}

public class GuaranteeInfo
{
    [JsonPropertyName("nameKratPoruch")]
    public string GuaranteeName { get; set; }

    [JsonPropertyName("nameFullPoruch")]
    public string GuaranteeFullName { get; set; }

    [JsonPropertyName("UrAddrPoruch")]
    public string GuaranteeLegalAddress { get; set; }

    [JsonPropertyName("OGRNPoruch")]
    public string GuaranteeOgrn { get; set; }

    [JsonPropertyName("INNPoruch")]
    public string GuaranteeInn { get; set; }

    [JsonPropertyName("kppPoruch")]
    public string GuaranteeKpp { get; set; }

    [JsonPropertyName("RSPoruch")]
    public string GuaranteePaymentAccount { get; set; }

    [JsonPropertyName("BankOKratPoruch")]
    public string GuaranteeBank { get; set; }

    [JsonPropertyName("KSPoruch")]
    public string GuaranteeCorrespondentAccount { get; set; }

    [JsonPropertyName("BIKPoruch")]
    public string GuaranteeBik { get; set; }

    [JsonPropertyName("FIORP_Gen_Dir")]
    public string GuaranteeSigner { get; set; }

    [JsonPropertyName("FIOKrat_Gen_Dir")]
    public string GuaranteeSignerImit { get; set; }
}
