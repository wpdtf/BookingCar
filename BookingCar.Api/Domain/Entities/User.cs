namespace BookingCar.Api.Domain.Entities;

public class User
{
    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Дата начала действия логина
    /// </summary>
    public DateOnly DateStart { get; set; }

    /// <summary>
    /// До какого числа работал\работает
    /// </summary>
    public DateOnly DateLast { get; set; }
}
