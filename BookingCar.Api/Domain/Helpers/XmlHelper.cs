namespace BookingCar.Api.Domain.Helpers;

/// <summary>
/// Хелпер для работы с xml от базы данных.
/// </summary>
public class XmlHelper
{
    /// <summary>
    /// Десериализации xml и запись его в требуемую модель данных. <br />
    /// В модели данных необходимо обозначить root, и раздать свойствам модели наименования подходящих тегов.
    /// </summary>
    /// <typeparam name="T">Модель данных в которую необходимо запись xml.</typeparam>
    /// <param name="xml">xml который необходимо запись в модель данных.</param>
    /// <returns>Возврат заполненой модели данных на основе полученного xml.</returns>
    public static T Deserialize<T>(string xml)
    {
        var serializer = new XmlSerializer(typeof(T));
        using var reader = new StringReader(xml);
        return (T)serializer.Deserialize(reader);
    }
}
