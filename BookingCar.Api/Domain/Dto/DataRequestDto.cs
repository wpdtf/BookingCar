namespace BookingCar.Api.Domain.Dto;

/// <summary>
/// Перечень данных необходимых для обработки шагов.
/// </summary>
public class DataRequestDto
{
    /// <summary>
    /// Ключ сессии клиента. <br />
    /// Ключевое поле таблицы dbo.LK_log. Необходим для проверки, что изначально клиент был в рамках данной сессии. <br />
    /// </summary>
    [Range(1, int.MaxValue, ErrorMessage = "Значение сессии не может быть отрицательным.")]
    public int Session { get; set; }

    /// <summary>
    /// Клиент который проходит шаг.
    /// </summary>
    [Range(10003, int.MaxValue, ErrorMessage = "Значение ключа клиента не может быть ниже {1}.")]
    public int ClientId { get; set; }

    /// <summary>
    /// Заявка которая проходит через шаги.
    /// </summary>
    [Range(10004, int.MaxValue, ErrorMessage = "Значение ключа заявки не может быть ниже {1}.")]
    public int LoanId { get; set; }

    /// <summary>
    /// С какого шага произошел вызов.
    /// </summary>
    /// <remarks>За исключением эндпойнта принудительной установки шаги должен переопределяться внутри контроллера.</remarks>
    public Steps Step { get; set; }

    /// <summary>
    /// Источник вызова, важно сохранять корректный источник вызова.
    /// </summary>
    [Required(ErrorMessage = "Источник вызова необходимо указывать.")]
    [EnumValidator(typeof(SourceCall))]
    public SourceCall SourceCall { get; set; }
}
