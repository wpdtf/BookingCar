namespace BookingCar.Api;

/// <summary>
/// Набор настроек из appSetting.json
/// </summary>
public class AppSettings
{
    /// <summary>
    /// Строки подключения
    /// </summary>
    [ValidateObjectMembers]
    public ConnectionStrings ConnectionStrings { get; set; }

    /// <summary>
    /// Урл для подключения к внешним сервисам
    /// </summary>
    public Uri GatewayUrl { get; set; }

    /// <summary>
    /// Токен для подключения к внешним сервисам (если требуется авторизация)
    /// </summary>
    public string GatewayToken { get; set; }

    /// <summary>
    /// Урл для подключения к внешнему сервису
    /// </summary>
    public Uri FindEntityUrl { get; set; }

    /// <summary>
    /// Дополнительные параметры для перехода с шага 232
    /// </summary>
    public SettingsSteps SettingsStep232 { get; set; }

    /// <summary>
    /// Дополнительные параметры для перехода с шага 207 вперед
    /// </summary>
    public SettingsSteps SettingsStep207 { get; set; }

    /// <summary>
    /// Дополнительные параметры для перехода с шага 207 назад
    /// </summary>
    public SettingsSteps SettingsStep207GoBack { get; set; }

    /// <summary>
    /// Дополнительные параметры для вызова хранимки о подписании договора
    /// </summary>
    public DepositSignedAdditionalParameters DepositSignedAdditionalParameters { get; set; }

    /// <summary>
    /// Дополнительные параметры для перехода с шага 49
    /// </summary>
    public SettingsSteps SettingsStep49 { get; set; }

    /// <summary>
    /// Время на которое будет сохраняться запрос в кэше.
    /// </summary>
    public int RequestStorageTimeForMinutes { get; set; }
}

public class ConnectionStrings
{
    /// <summary>
    /// Подключение к MS SQL
    /// </summary>
    [Required]
    public string MsSqlConnection { get; set; }

    /// <summary>
    /// Подключение к opentelemetry
    /// </summary>
    public Uri OtelCollectorUrl { get; set; }
}

public class SettingsSteps
{
    /// <summary>
    /// Тип дополнительного условия для смены шага (keyS = 195)
    /// </summary>
    public int Extratype { get; set; }

    /// <summary>
    /// Дополнительное условие для смены шага (keyS = DopPr)
    /// </summary>
    public int Extrakey { get; set; }
}

public class DepositSignedAdditionalParameters
{
    /// <summary>
    /// Нужно ли отменять заявку после 3-х неуспешных вводов АСП, по умолчанию надо
    /// </summary>
    /// <remarks>В sql это smallint поля, хоть значение и предполагает 2 состояния да\нет</remarks>
    public short NeedCancel { get; set; }

    /// <summary>
    /// Нужно ли менять интервал ожидания смс в зависимости от количества
    /// </summary>
    /// <remarks>В sql это smallint поля, хоть значение и предполагает 2 состояния да\нет</remarks>
    public short NeedChange { get; set; }
}

