namespace BookingCar.Api.Domain.Entities;

public class Booking
{
    /// <summary>
    /// Ключ брования
    /// </summary>
    public int BookingId { get; set; }

    /// <summary>
    /// Ключ автомобиля
    /// </summary>
    public string CarId { get; set; }

    /// <summary>
    /// Ключ клиента
    /// </summary>
    public string ClientId { get; set; }

    /// <summary>
    /// Статус бронирования
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Время создания бронирования
    /// </summary>
    public string BookingTime { get; set; }

    /// <summary>
    /// Время начала поездки
    /// </summary>
    public DateOnly BookingStart { get; set; }
}
