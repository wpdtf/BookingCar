namespace BookingCar.Api.Domain.Dto;

public class CreateUserDTO
{
    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль сотрудника
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Пароль сотрудника
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Пароль сотрудника
    /// </summary>
    public DateOnly DateLactActual { get; set; }
}
