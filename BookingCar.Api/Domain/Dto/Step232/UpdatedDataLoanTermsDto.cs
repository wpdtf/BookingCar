namespace BookingCar.Api.Domain.Dto.Step232;

/// <summary>
/// Объект входных параметров для обновления условий займа.
/// </summary>
public class UpdatedDataLoanTermsDto
{
    /// <summary>
    /// Стандартный набор входных параметров.
    /// </summary>
    [Required(ErrorMessage = "Необходимо передавать набор обязательных свойств (сессия, клиент, заявка...).")]
    public DataRequestDto DataRequest { get; set; }

    /// <summary>
    /// Ключ продукта.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "Продукт не может быть отрицательным.")]
    public int ProductId { get; set; }

    /// <summary>
    /// Сумма по продукту.
    /// </summary>
    [Range(1000, int.MaxValue, ErrorMessage = "Мы выдаем не меньше {1} руб.")]
    public decimal ProductSumma { get; set; }

    /// <summary>
    /// Срок продукта.
    /// </summary>
    [Range(0, int.MaxValue, ErrorMessage = "Срок продукта не может быть отрицательным.")]
    public decimal ProductTerm { get; set; }
}
