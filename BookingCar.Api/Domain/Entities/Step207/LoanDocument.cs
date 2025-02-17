namespace BookingCar.Api.Domain.Entities.Step207;

/// <summary>
/// Модель данных для объекта договора займа.
/// </summary>
public class LoanDocument
{
    /// <summary>
    /// Общая информация по заявке.
    /// </summary>
    public List<LoanInfo> LoanInfo { get; set; } = new List<LoanInfo>();

    /// <summary>
    /// Индивидуальные условия заема.
    /// </summary>
    public List<LoanIndividualConditions> LoanIndividualConditions { get; set; } = new List<LoanIndividualConditions>();

    /// <summary>
    /// Преамбула для файла заема.
    /// </summary>
    public List<LoanPreamble> LoanPreamble { get; set; } = new List<LoanPreamble>();

    /// <summary>
    /// Подпись к индивидуальным условиям займа.
    /// </summary>
    public List<LoanIndividualConditionsCaption> LoanIndividualConditionsCaption { get; set; } = new List<LoanIndividualConditionsCaption>();

    /// <summary>
    /// График платежей.
    /// </summary>
    public List<LoanPaymentSchedule> LoanPaymentSchedule { get; set; } = new List<LoanPaymentSchedule>();

    /// <summary>
    /// Описания для графика платежей. <br />
    /// Дополнительные пункты.
    /// </summary>
    public List<LoanPaymentScheduleCaption> LoanPaymentScheduleCaption { get; set; } = new List<LoanPaymentScheduleCaption>();
}

public class LoanInfo
{
    [JsonPropertyName("keyDZ")]
    public int LoanId { get; set; }

    [JsonPropertyName("PSK")]
    public string LoanTic { get; set; }

    [JsonPropertyName("PSK_New")]
    public string LoanTicNewCalc { get; set; }

    [JsonPropertyName("pskCaption")]
    public string LoanTicCaption { get; set; }

    [JsonPropertyName("UID")]
    public string LoanUid { get; set; }

    [JsonPropertyName("Nomer")]
    public string LoanNomer { get; set; }

    [JsonPropertyName("PodNomer")]
    public string LoanNomerCaption { get; set; }

    [JsonPropertyName("Town")]
    public string LoanTown { get; set; }

    [JsonPropertyName("Dt")]
    public string LoanDate { get; set; }

    [JsonPropertyName("Signer")]
    public string LoanSigner { get; set; }

    [JsonPropertyName("keyOH")]
    public int OrganizationId { get; set; }

    [JsonPropertyName("NameOrgKrat")]
    public string OrganizationName { get; set; }

    [JsonPropertyName("FIO")]
    public string ClientFullName { get; set; }

    [JsonPropertyName("keyPart")]
    public int ClientId { get; set; }

    [JsonPropertyName("SNILS")]
    public string ClientSnils { get; set; }

    [JsonPropertyName("INN")]
    public string ClientInn { get; set; }
}

public class LoanIndividualConditions
{
    [JsonPropertyName("NUMBER")]
    public string ConditionId { get; set; }

    [JsonPropertyName("CONDITION")]
    public string Condition { get; set; }

    [JsonPropertyName("CONDITION_CONTENT")]
    public string ConditionValue { get; set; }

    [JsonPropertyName("NeedPodp")]
    public int ConditionSignature { get; set; }
}

public class LoanPreamble
{
    [JsonPropertyName("nom")]
    public int PreambleId { get; set; }

    [JsonPropertyName("PREAMBULA_CONTENT")]
    public string PreambleValue { get; set; }
}

public class LoanIndividualConditionsCaption
{
    [JsonPropertyName("nom")]
    public int IndividualConditionsCaptionId { get; set; }

    [JsonPropertyName("AFTER_IU_CONTENT")]
    public string IndividualConditionsCaptionValue { get; set; }
}

public class LoanPaymentSchedule
{
    [JsonPropertyName("PAYMENT_DATE")]
    public string PaymentDate { get; set; }

    [JsonPropertyName("PAYMENT")]
    public decimal PaymentFull { get; set; }

    [JsonPropertyName("MAIN_DEBT")]
    public decimal PaymentMain { get; set; }

    [JsonPropertyName("PERCENTAGE")]
    public decimal PaymentPercentage { get; set; }
}

public class LoanPaymentScheduleCaption
{
    public string Item1 { get; set; }

    public string Item2 { get; set; }

    public string Item3 { get; set; }

    public string Item4 { get; set; }

    public string Item5 { get; set; }

    public string Item6 { get; set; }

    public string Item7 { get; set; }

    [JsonPropertyName("BeforeSchedule")]
    public string PaymentScheduleCaption { get; set; }

    [JsonPropertyName("PSK")]
    public string LoanTic { get; set; }
}
