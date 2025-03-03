namespace BookingCar.Api.Controllers;

/// <summary>
/// Контроллер для общих методов.
/// </summary>
[Route("api/booking-car/booking/")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingRepository _bookingRepository;

    public BookingController(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    /// <summary>
    /// Редактирование автомобилей
    /// </summary>
    /// <param name="car">Какого автомобиля</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpPut("car")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> EditCarAsync([FromBody] Car car)
    {
        await _bookingRepository.EditCarAsync(car);
        return NoContent();
    }

    /// <summary>
    /// Получение данных по автомобилю
    /// </summary>
    /// <param name="carId">По какому автомобилю</param>
    /// <param name="onlyActive">Только активные автомобили</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpGet("car")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewCarAsync([FromQuery] int carId, bool onlyActive)
    {
        return Ok(await _bookingRepository.ViewCarAsync(carId, onlyActive));
    }

    /// <summary>
    /// Редактирование тарифов
    /// </summary>
    /// <param name="tariff">Какого тарифа</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpPut("tariff")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> EditTariffAsync([FromBody] Tariff tariff)
    {
        await _bookingRepository.EditTariffAsync(tariff);
        return NoContent();
    }

    /// <summary>
    /// Получение данных по тарифам
    /// </summary>
    /// <param name="tariffId">Какого тарифа</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpGet("tariff")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewTariffAsync([FromQuery] int tariffId)
    {
        return Ok(await _bookingRepository.ViewTariffAsync(tariffId));
    }

    /// <summary>
    /// Тарифы и автомобили
    /// </summary>
    /// <param name="tariff">Какого автомобиля</param>
    /// <param name="carId">Какого тарифа</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpPut("tariffToCar")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> EditTariffToCar([FromQuery] int tariff, int carId)
    {
        await _bookingRepository.EditTariffToCarAsync(tariff, carId);
        return NoContent();
    }

    /// <summary>
    /// Просмотр тарифы и автомобили
    /// </summary>
    /// <param name="tariff">Какого автомобиля</param>
    /// <param name="carId">Какого тарифа</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpGet("tariffToCar")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewTariffToCarAsync([FromQuery] int carId)
    {
        return Ok(await _bookingRepository.ViewTariffToCarAsync(carId));
    }

    /// <summary>
    /// Редактирование бронирований
    /// </summary>
    /// <param name="booking">Какого бронирования</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpPut("booking")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> EditBookingAsync([FromBody] Booking booking)
    {
        await _bookingRepository.EditBookingAsync(booking);
        return NoContent();
    }

    /// <summary>
    /// Получение данных по бронированиям
    /// </summary>
    /// <param name="bookingId">По какому бронированию</param>
    /// <param name="clientId">По какому клиенту</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpGet("booking")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewBookingAsync([FromQuery] int bookingId, int clientId)
    {
        return Ok(await _bookingRepository.ViewBookingAsync(bookingId, clientId));
    }

    /// <summary>
    /// Редактирование инцидентов
    /// </summary>
    /// <param name="incident">Какого инцидента</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpPut("incident")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> EditIncidentAsync([FromBody] Incident incident)
    {
        await _bookingRepository.EditIncidentAsync(incident);
        return NoContent();
    }

    /// <summary>
    /// Получение данных по инциденту
    /// </summary>
    /// <param name="incideintId">По какому инциденту</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpGet("incident")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewIncidentAsync([FromQuery] int incideintId)
    {
        return Ok(await _bookingRepository.ViewIncidentAsync(incideintId));
    }

    /// <summary>
    /// Получение клиентов которым доступен определенный автомобиль
    /// </summary>
    /// <param name="carId">По какому автомобилю</param>
    /// <returns>При успешном выполнении вернутся данные, или ошибка.</returns>
    [HttpGet("client-to-car")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ClientToCarAsync([FromQuery] int carId)
    {
        return Ok(await _bookingRepository.ViewClientToCarAsync(carId));
    }
}
