namespace BookingCar.Api.Domain.Entities;

public class Incident
{
    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public int IncidentId { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public int BookingId { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public bool ClientGuilty { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Логин сотрудника
    /// </summary>
    public string NomerTicket { get; set; }
}
