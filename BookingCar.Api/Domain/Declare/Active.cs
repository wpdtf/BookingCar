namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Активен ли параметр. <br />
/// Используется для работы с базой.
/// </summary>
/// <remarks>Например использовать в ХП с needSelect.</remarks>
public enum Active : short
{
    /// <summary>
    /// Активен.
    /// </summary>
    Enabled = 1,

    /// <summary>
    /// Не активен.
    /// </summary>
    Disabled = 0
}
