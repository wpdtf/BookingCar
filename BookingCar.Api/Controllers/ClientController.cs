namespace BookingCar.Api.Controllers;

/// <summary>
/// Контроллер для общих методов.
/// </summary>
[Route("api/booking-car/client/")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly IClientRepository _clientRepository;

    public ClientController(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    /// <summary>
    /// Получение данных по клиента
    /// </summary>
    /// <param name="clientId">По конкретному клиенту</param>
    /// <returns>При успешном выполнении вернутся данные по клиентам, или ошибка.</returns>
    [HttpGet("list")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewClientAsync([FromQuery] int clientId)
    {
        return Ok(await _clientRepository.ViewClientAsync(clientId));
    }

    /// <summary>
    /// Отредактировать данные по клиенту
    /// </summary>
    /// <param name="client">Модель данных клиента</param>
    /// <returns>При успешном выполнении вернутся данные по сотруднику, или ошибка.</returns>
    [HttpPut("edit")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> UpdateUserAsync([FromBody] Client client)
    {
        await _clientRepository.EditClientAsync(client);
        return NoContent();
    }

    /// <summary>
    /// Получение данных по клиента
    /// </summary>
    /// <param name="clientId">По конкретному клиенту</param>
    /// <returns>При успешном выполнении вернутся данные по клиентам, или ошибка.</returns>
    [HttpGet("experience")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ClientExperienceAsync([FromQuery] int clientId)
    {
        return Ok(new { Experience = await _clientRepository.GetExperienceClientAsync(clientId) });
    }
}
