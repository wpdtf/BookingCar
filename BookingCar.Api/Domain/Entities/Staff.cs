namespace BookingCar.Api.Domain.Entities;

public class Staff
{
    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string Last_name { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string First_name { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string Middle_name { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public DateOnly Birthdate { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public bool Dismissed { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public short Position { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string PositionTxt { get; set; }
}
