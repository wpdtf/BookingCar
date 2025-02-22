namespace BookingCar.Api.Controllers;

/// <summary>
/// Контроллер для общих методов.
/// </summary>
[Route("api/booking-car/report/")]
[ApiController]
public class ReportController : ControllerBase
{
    private readonly IReportRepository _reportRepository;

    public ReportController(IReportRepository reportRepository)
    {
        _reportRepository = reportRepository;
    }

    /// <summary>
    /// Получение данных по поездкам (всем или по клиенту)
    /// </summary>
    /// <param name="clientId">По конкретному клиенту</param>
    /// <returns>При успешном выполнении вернутся данные по клиентам, или ошибка.</returns>
    [HttpGet("client-to-booking")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewReportToBookingClientAsync([FromQuery] int clientId)
    {
        return Ok(await _reportRepository.ViewClientBookingAsync(clientId));
    }

    /// <summary>
    /// Получение данных по инцидентам (всем или по клиенту)
    /// </summary>
    /// <param name="clientId">По конкретному клиенту</param>
    /// <returns>При успешном выполнении вернутся данные по клиентам, или ошибка.</returns>
    [HttpGet("client-to-incident")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewReportToIncideintClientAsync([FromQuery] int clientId)
    {
        return Ok(await _reportRepository.ViewClientIncidentAsync(clientId));
    }

    /// <summary>
    /// Получение данных по ареднам (всем или по авто)
    /// </summary>
    /// <param name="carId">По конкретному автомобилю</param>
    /// <returns>При успешном выполнении вернутся данные по авто, или ошибка.</returns>
    [HttpGet("car-to-booking")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewReportToBookingCarAsync([FromQuery] int carId)
    {
        return Ok(await _reportRepository.ViewCarBookingAsync(carId));
    }

    /// <summary>
    /// Получение данных по инцидентав у авто (всем или по авто)
    /// </summary>
    /// <param name="carId">По конкретному автомобилю</param>
    /// <returns>При успешном выполнении вернутся данные по авто, или ошибка.</returns>
    [HttpGet("car-to-incident")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewReportToIncideintCarAsync([FromQuery] int carId)
    {
        return Ok(await _reportRepository.ViewCarIncidentAsync(carId));
    }
}
