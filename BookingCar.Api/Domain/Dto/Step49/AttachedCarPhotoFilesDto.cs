namespace BookingCar.Api.Domain.Dto.Step49;

/// <summary>
/// Объект входных параметров для сохранения прикрепленных файлов.
/// </summary>
public class AttachedCarPhotoFilesDto
{
    /// <summary>
    /// Стандартный набор входных параметров.
    /// </summary>
    [Required(ErrorMessage = "Необходимо передавать набор обязательных свойств (сессия, клиент, заявка...).")]
    public DataRequestDto DataRequest { get; set; }

    /// <summary>
    /// Список прикрепленных файлов.
    /// </summary>
    public List<CarPhotoFilesDto> Files { get; set; }
}
