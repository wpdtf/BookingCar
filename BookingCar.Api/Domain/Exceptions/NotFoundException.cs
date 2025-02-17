namespace BookingCar.Api.Domain.Exceptions;

/// <summary>
/// Кастомная ошибка для отображения отсутствия сущности.
/// </summary>
/// <remarks>
/// Обработка реализована в <seealso cref="Program"/>.<br />
/// Реализация поиска сущности <seealso cref="FindEntityService"/>.
/// </remarks>
[Serializable]
public class NotFoundException : Exception
{
    public NotFoundException()
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
