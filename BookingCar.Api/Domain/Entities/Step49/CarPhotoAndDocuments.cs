namespace BookingCar.Api.Domain.Entities;

/// <summary>
/// Модель данных для получения результата ХП Loan.CarPhotoAndDocumentsGet.
/// </summary>
public class CarPhotoAndDocuments
{
    public int Id { get; set; }

    public string FileName { get; set; }

    public string DocumentTypeName { get; set; }

    public bool? IsDigital { get; set; }

    public CarFileType FileCategory { get; set; }
}
