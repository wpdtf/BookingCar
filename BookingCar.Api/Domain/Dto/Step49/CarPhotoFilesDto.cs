namespace BookingCar.Api.Domain.Dto.Step49;

/// <summary>
/// Объект параметров файла.
/// </summary>
public class CarPhotoFilesDto
{
    /// <summary>
    /// ID файла.
    /// </summary>
    public int FileId { get; set; }

    /// <summary>
    /// Тип файла.
    /// </summary>
    public int FileType { get; set; }

    /// <summary>
    /// Ссылка на файл.
    /// </summary>
    [Required(ErrorMessage = "Необходимо указывать ссылку на загруженный файл.")]
    public string FileUrl { get; set; }
}
