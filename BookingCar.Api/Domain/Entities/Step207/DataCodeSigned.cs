namespace BookingCar.Api.Domain.Entities.Step232;

/// <summary>
/// Модель данных для возврата ответа о работе с кодом АСП.
/// </summary>
public class DataCodeSigned
{
    /// <summary>
    /// Успешный ли результат проверки.
    /// </summary>
    /// <remarks>
    /// Если код АСП введен не правильный, то ошибка падать не будет, а через эту переменную можно будет проверить. <br />
    /// Если проблема будет в чем то другом, то сама процедура выпадет в ошибку.
    /// </remarks>
    public Result Res { get; set; }

    /// <summary>
    /// Дополнительно код ошибки.
    /// </summary>
    /// <remarks>
    /// Актуально т.к этот метод может вернуть не желательный результат без ошибки.
    /// </remarks>
    public int? ErrorCode { get; set; } //TODO: рефакторинг был бы слишком долгий, то пока возвращаю так

    /// <summary>
    /// Дополнительное текстовое сообщение о запросе.
    /// </summary>
    /// <remarks>
    /// Актуально т.к этот метод может вернуть не желательный результат без ошибки.
    /// </remarks>
    public string Message { get; set; } //TODO: рефакторинг был бы слишком долгий, то пока возвращаю так

    /// <summary>
    /// Количество оставшихся секунд времени жизни кода АСП.
    /// </summary>
    public int CntSec { get; set; }

    /// <summary>
    /// Количество оставшихся попыток ввести код АСП.
    /// </summary>
    public int CntAttempts { get; set; }

    /// <summary>
    /// Количество секунд которое прошло после последней отправки кода АСП.
    /// </summary>
    /// <remarks>Если код АСП актуален, то значение будет отрицательное.</remarks>
    public int CntSecForNextSend { get; set; }

    /// <summary>
    /// Канал отправки кода АСП.
    /// </summary>
    public short ChannelASP { get; set; }

    /// <summary>
    /// Маска телефона с которого была отправка кода АСП.
    /// </summary>
    public string PhoneMaskASP { get; set; }
}
