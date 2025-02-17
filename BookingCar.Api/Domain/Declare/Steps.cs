namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Шаги которые обрабатываются через сервис.
/// </summary>
/// <remarks>Используется только для логики внутри сервиса.</remarks>
public enum Steps
{
    /// <summary>
    /// Калькулятор перед подписанием залогового займа.
    /// </summary>
    [Description("КалькуляторПередПодписаниемДоговора232")]
    Step232 = 232,

    /// <summary>
    /// Подписание залогового займа.
    /// </summary>
    [Description("ПодписаниеДоговора207")]
    Step207 = 207,

    /// <summary>
    /// Добавление фото авто и документов.
    /// </summary>
    [Description("ДобавлениеФотоАвто49")]
    Step49 = 49
}
