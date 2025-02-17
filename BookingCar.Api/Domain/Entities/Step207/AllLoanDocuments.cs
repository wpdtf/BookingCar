namespace BookingCar.Api.Domain.Entities.Step207;

/// <summary>
/// Модель данных для предоставления клиенту по залоговой заявке.
/// </summary>
public class AllLoanDocuments
{
    /// <summary>
    /// Стандартный договор займа.
    /// </summary>
    public LoanDocument LoanAgreementTerms { get; set; } = new LoanDocument();

    /// <summary>
    /// Договор залога.
    /// </summary>
    public DepositAgreement DepositAgreement { get; set; }

    /// <summary>
    /// Договор поручительства.
    /// </summary>
    public GuaranteeAgreement GuaranteeAgreement { get; set; }

    /// <summary>
    /// Уведомление о рисках.
    /// </summary>
    public RiskNotification RiskNotification { get; set; }
}

public class PledgerInfo
{
    [JsonPropertyName("UrAddr")]
    public string OrganizationLegalAddress { get; set; }

    [JsonPropertyName("OGRN")]
    public string OrganizationOgrn { get; set; }

    [JsonPropertyName("INN")]
    public string OrganizationInn { get; set; }

    [JsonPropertyName("KPP")]
    public string OrganizationKpp { get; set; }

    [JsonPropertyName("BIK")]
    public string OrganizationBik { get; set; }

    [JsonPropertyName("RS")]
    public string OrganizationRs { get; set; }

    [JsonPropertyName("Bank")]
    public string OrganizationBank { get; set; }

    [JsonPropertyName("KS")]
    public string OrganizationCorporateAccount { get; set; }

    public string SignerDoljnImit { get; set; }

    public string SignerIminit { get; set; }
}

public class LoanInfoForDepositAndGuarantee
{
    [JsonPropertyName("keyPart")]
    public int ClientId { get; set; }

    public string OrgNameKrat { get; set; }

    [JsonPropertyName("NomerDogovor")]
    public string LoanNomer { get; set; }

    [JsonPropertyName("DateDogovor")]
    public string LoanDate { get; set; }

    [JsonPropertyName("Date")]
    public string AgreementDate { get; set; }

    public string OrgNameFull { get; set; }

    public string SignerDoljnRp { get; set; }

    public string Signer { get; set; }

    public string SignerDoverNomer { get; set; }

    public string SignerDoverDat { get; set; }

    [JsonPropertyName("NamePartner")]
    public string ClientFullName { get; set; }

    [JsonPropertyName("dateB")]
    public string ClientBirthDate { get; set; }

    [JsonPropertyName("PASP_Serial")]
    public int ClientPassportSerial { get; set; }

    [JsonPropertyName("PASP_Number")]
    public int ClientPassportNumber { get; set; }

    [JsonPropertyName("PASP_IssuedBy")]
    public string ClientPassportIssuedBy { get; set; }

    [JsonPropertyName("PASP_IssuedDate")]
    public string ClientPassportIssuedDate { get; set; }

    [JsonPropertyName("PASP_IssuedCode")]
    public string ClientPassportIssuedCode { get; set; }

    [JsonPropertyName("PASP_PlaceB")]
    public string ClientPassportBirthPlace { get; set; }

    [JsonPropertyName("REG_Addr")]
    public string ClientRegistrationAddress { get; set; }

    [JsonPropertyName("FAKT_Addr")]
    public string ClientResidenceAddress { get; set; }

    [JsonPropertyName("NameTown")]
    public string ClientTownName { get; set; }

    [JsonPropertyName("summCredit")]
    public string LoanAmount { get; set; }

    [JsonPropertyName("summCreditTxt")]
    public string LoanAmountText { get; set; }

    [JsonPropertyName("datePogash")]
    public string LoanRepaymentDate { get; set; }

    [JsonPropertyName("procent")]
    public string LoanIntrest { get; set; }

    [JsonPropertyName("ProcPeny")]
    public string LoanPeny { get; set; }
}
