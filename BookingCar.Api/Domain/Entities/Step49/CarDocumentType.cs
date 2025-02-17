namespace BookingCar.Api.Domain.Entities.Step49;

/// <summary>
/// Модель данных для формирования списка документов авто.
/// </summary>
public class CarDocumentType
{
    public List<CarFilesInfo> Digital { get; set; }

    public List<CarFilesInfo> Paper { get; set; }
}
