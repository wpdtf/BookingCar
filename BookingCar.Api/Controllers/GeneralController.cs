namespace BookingCar.Api.Controllers;

/// <summary>
/// Контроллер для общих методов.
/// </summary>
[Route("api/po-auto-loan-steps/general-methods/")]
[ApiController]
public class GeneralController : ControllerBase
{
    private readonly GeneralService _generalService;

    public GeneralController(GeneralService generalService)
    {
        _generalService = generalService;
    }

    /// <summary>
    /// Принудительно указать необходимый шаг заявке.
    /// </summary>
    /// <param name="request">Модель необходимых данных для запроса.</param>
    /// <param name="stepExtra">Тип дополнительного условия для шага.</param>
    /// <returns>При успешном прохождении шага статус 204, или ошибка.</returns>
    [HttpPost("set-step")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType(typeof(ProblemDetails))]
    public async Task<IActionResult> SetStepAsync([FromBody] DataRequestDto request, [FromQuery] int stepExtra) //TODO: Временное решение, по плану этот эндпоинт используется только на шаге 207, Игорь Коливушка должен будет заменить вызов на более корректный эндпоинт
    {
        await _generalService.CheckLoanExistsAsync(request.LoanId);

        await _generalService.MoveStepAsync(request, 0, 0, 0, stepExtra, 1);

        return Ok(new { result = Result.Successfully });
    }
}
