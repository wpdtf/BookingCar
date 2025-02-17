namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Типы взаимодействий с кодом АСП
/// </summary>
public enum TypeCheckCodeAsp
{
    /// <summary>
    /// Стандартная отправка кода АСП, функционал отправки решит каким образом отправить
    /// </summary>
    defaultSendCodeAsp = 0,

    /// <summary>
    /// Проверить имеющийся код АСП
    /// </summary>
    checkCodeAsp = 1,

    /// <summary>
    /// Принудительно отправить код АСП через СМС сообщение
    /// </summary>
    SendCodeAspAnSms = 3,

    /// <summary>
    /// Принудительно отправить код АСП через звонок
    /// </summary>
    SendCodeAspAnCall = 4
}
