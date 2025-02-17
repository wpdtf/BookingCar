namespace BookingCar.Api.Domain.Dto.Step207;

/// <summary>
/// Входные данные для подписи договора залога.
/// </summary>
public class DogovorDepositSignedDto
{
    /// <summary>
    /// Стандартный набор входных параметров.
    /// </summary>
    [Required(ErrorMessage = "Необходимо передавать набор обязательных свойств (сессия, клиент, заявка...).")]
    public DataRequestDto DataRequest { get; set; }

    /// <summary>
    /// Код АСП. <br />
    /// Необходим для проверки корректности кода.
    /// </summary>
    public string SignedCode { get; set; }

    /// <summary>
    /// Тип запроса по проверке, т.к в БД это единная логика.
    /// </summary>
    [Required(ErrorMessage = "Необходимо указывать тип проверки.")]
    [EnumValidator(typeof(TypeCheckCodeAsp))]
    public TypeCheckCodeAsp TypeCheck { get; set; }
}
