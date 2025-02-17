namespace BookingCar.Api.Domain.Declare;

/// <summary>
/// Выполнена ли хранимая процедура.
/// </summary>
/// <remarks>
/// Также передается в web для определения успешного запроса. <br />
/// Вот тут <seealso cref="DataCodeSigned.Res"/>.
/// </remarks>
public enum Result : short
{
    /// <summary>
    /// Выполнено успешно 
    /// </summary>
    Successfully = 1,

    /// <summary>
    /// Выполнено не успешно
    /// </summary>
    Failed = 0
}
