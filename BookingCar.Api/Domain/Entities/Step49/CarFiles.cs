namespace BookingCar.Api.Domain.Entities.Step49;

/// <summary>
/// Модель данных для формирования списка файлов для веба.
/// </summary>
public class CarFiles
{
    /// <summary>
    /// Список необходимых фото.
    /// </summary>
    public List<CarFilesInfo> CarPhoto { get; set; } = new List<CarFilesInfo>();

    /// <summary>
    /// Список необходимых документов с разбивкой на электронные и бумажные.
    /// </summary>
    public CarDocumentType CarDocument { get; set; } = new CarDocumentType();

    /// <summary>
    /// Сообщение для клиента.
    /// </summary>
    public string TextMessage { get; set; }
}
