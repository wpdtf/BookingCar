namespace BookingCar.Api.Controllers;

/// <summary>
/// Контроллер для общих методов.
/// </summary>
[Route("api/booking-car/tech-support/")]
[ApiController]
public class TechSupportController : ControllerBase
{
    private readonly IGeneralRepository _generalRepository;

    public TechSupportController(IGeneralRepository generalRepository)
    {
        _generalRepository = generalRepository;
    }

    /// <summary>
    /// Авторизация сотрудника в приложении
    /// </summary>
    /// <param name="authDTO">Данные для авторизации</param>
    /// <returns>При успешном выполнении вернутся данные по сотруднику, или ошибка.</returns>
    [HttpPost("auth")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> AuthAsync([FromBody] AuthDTO authDTO)
    {
        return Ok(await _generalRepository.AutorizationAsync(authDTO));
    }

    /// <summary>
    /// Получение данных по логинам сотрудника
    /// </summary>
    /// <param name="userId">Сотрудник по которому выводим данные</param>
    /// <param name="isFull">Весь ли список вывести</param>
    /// <returns>При успешном выполнении вернутся данные по сотруднику, или ошибка.</returns>
    [HttpGet("auth")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewAuthAsync([FromQuery] int userId, bool isFull)
    {
        return Ok(await _generalRepository.ViewUserAsync(userId, isFull));
    }

    /// <summary>
    /// Создаем\редактируем пользователя
    /// </summary>
    /// <param name="createDTO">Данные для создания клиента</param>
    /// <returns>При успешном выполнении вернутся данные по сотруднику, или ошибка.</returns>
    [HttpPut("auth")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> UpdateUserAsync([FromBody] CreateUserDTO createDTO)
    {
        await _generalRepository.CreateUserAsync(createDTO);
        return NoContent();
    }

    /// <summary>
    /// Просматриваем всех сотрудников
    /// </summary>
    /// <returns>При успешном выполнении вернутся данные по сотруднику, или ошибка.</returns>
    [HttpGet("staff")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewStaffAsync()
    {
        return Ok(await _generalRepository.ViewStaffAsync());
    }

    /// <summary>
    /// Редактируем данные по сотрудникам
    /// </summary>
    /// <returns>При успешном выполнении вернутся данные по сотруднику, или ошибка.</returns>
    [HttpPut("staff")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> UpdateStaffAsync([FromBody] Staff staff)
    {
        await _generalRepository.CreateStaffAsync(staff);
        return NoContent();
    }

    /// <summary>
    /// Получение данных по справочникам
    /// </summary>
    /// <returns>При успешном выполнении вернутся данные по справочникам, или ошибка.</returns>
    [HttpGet("spr")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> ViewSprAsync([FromQuery] int spr)
    {
        return Ok(await _generalRepository.ViewSprAsync(spr));
    }
}
