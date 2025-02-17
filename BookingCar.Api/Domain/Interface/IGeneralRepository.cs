namespace BookingCar.Api.Domain.Interface;

/// <summary>
/// Запрос данных из базы по общим методам. <br />
/// Общие документы необходимые для оформления займа. <br />
/// Получение доступных продуктов. <br />
/// Толкание заявки вперед\назад.
/// </summary>
public interface IGeneralRepository
{
    /// <summary>
    /// Проверка корректности текущей сессии и шага.
    /// </summary>
    /// <param name="dataRequest">Набор стандартных параметров.</param>
    /// <returns>Если проверка не пройдена выпадет ошибка.</returns>
    public Task CheckVerificationSessionAsync(DataRequestDto dataRequest);

    /// <summary>
    /// Прохождение по шагам.
    /// </summary>
    /// <param name="dataRequest">Набор стандартных параметров.</param>
    /// <param name="extratype">Тип дополнительного условия для прохождения (spr = 197).</param>
    /// <param name="extrakey">Дополнительное условие для прохождения (spr = dopPr).</param>
    /// <param name="moveType">В каком направлении движемся.</param>
    /// <param name="extraStep">Дополнительный ключ шага.</param>
    /// <param name="typeCheck">
    /// Eсли 0 то проверяем куда можем уйти с указанного шага. <br />
    /// Если 1 то переходим на уканный шаг, в таком случае не учитываются все остальные параметры кроме шага и его дополнительного ключа.
    /// </param>
    /// <returns>Если далеко не ушли, то будет ошибка.</returns>
    public Task MoveStepAsync(DataRequestDto dataRequest, int extratype, int extrakey, MoveType moveType, int extraStep = 1, int typeCheck = 0);
}
