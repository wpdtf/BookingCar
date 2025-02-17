namespace BookingCar.Api.Domain.Entities;

public class Auth
{
    /// <summary>
    /// Полное ФИО авторизованного сотрудника.
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Удален (уволен) ли сотрудник.
    /// </summary>
    public bool IsDelete { get; set; }

    /// <summary>
    /// Должность сотрудника.
    /// </summary>
    public string Position { get; set; }
}
