namespace BookingCar.Api.Domain.Entities;

public class Client
{
    /// <summary>
    /// Ключ клиента
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Фамилия клиента
    /// </summary>
    public string Last_name { get; set; }

    /// <summary>
    /// Имя клиента
    /// </summary>
    public string First_name { get; set; }

    /// <summary>
    /// Отчество клиента
    /// </summary>
    public string? Middle_name { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateOnly Birthdate { get; set; }

    /// <summary>
    /// Номер телефона клиента
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Почта клиента
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Паспорт клиента
    /// </summary>
    public string Passport { get; set; }

    /// <summary>
    /// Номер водительского
    /// </summary>
    public string DriverLicense { get; set; }

    /// <summary>
    /// Дата начала вождения
    /// </summary>
    public DateOnly DateStartDriving { get; set; }

    /// <summary>
    /// Заблокирован ли пользователь
    /// </summary>
    public bool Blocked { get; set; }

    /// <summary>
    /// Стаж вождения в годах
    /// </summary>
    public int? Experience { get; set; }
}
