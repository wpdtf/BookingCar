namespace BookingCar.Api.Domain.Interface;

public interface IReportRepository
{
    /// <summary>
    /// Отчет по бронированиям клиента, или по всем
    /// </summary>
    /// <param name="clientId">По какому клиенту</param>
    Task<IEnumerable<ReportForClientBooking>> ViewClientBookingAsync(int clientId);

    /// <summary>
    /// Отчет по инцидиентам клиента, или по всем
    /// </summary>
    /// <param name="clientId">По какому клиенту</param>
    Task<IEnumerable<ReportForClientIncident>> ViewClientIncidentAsync(int clientId);

    /// <summary>
    /// Отчет по бронирования автомобиля, или по всем
    /// </summary>
    /// <param name="carId">По какому авто</param>
    Task<IEnumerable<ReportForClientBooking>> ViewCarBookingAsync(int carId);

    /// <summary>
    /// Отчет по инцидиентам авто, или по всем
    /// </summary>
    /// <param name="carId">По какому авто</param>
    Task<IEnumerable<ReportForClientIncident>> ViewCarIncidentAsync(int carId);
}
