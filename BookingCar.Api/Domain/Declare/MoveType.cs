namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Как можем двигаться по шагам.
/// </summary>
public enum MoveType
{
    /// <summary>
    /// Двигаемся вперед, к следующему шагу.
    /// </summary>
    Forward = 1,

    /// <summary>
    /// Двигаемся назад, к предыдущему шагу.
    /// </summary>
    Backward = -1
}
