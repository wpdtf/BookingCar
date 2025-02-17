namespace BookingCar.Api.Domain.Entities.Step207;

[XmlRoot("root")]
public class RiskNotification
{
    [XmlElement("UrAddr")]
    public string OrganizationLegalAddress { get; set; }

    [XmlElement("OGRN")]
    public string OrganizationOgrn { get; set; }

    [XmlElement("INN")]
    public string OrganizationInn { get; set; }

    [XmlElement("KPP")]
    public string OrganizationKpp { get; set; }

    [XmlElement("NameOFull")]
    public string OrganizationFullName { get; set; }

    [XmlElement("NameOKrat")]
    public string OrganizationName { get; set; }

    [XmlElement("FIO")]
    public string ClientFullName { get; set; }

    [XmlElement("dat")]
    public string LoanDate { get; set; }

    [XmlElement("ASP")]
    public string LoanCodeSigned { get; set; }
}
