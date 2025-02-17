namespace BookingCar.Api.Domain.Interface;

public interface IGeneralRepository
{
    /// <summary>
    /// Проверка корректности текущей сессии и шага.
    /// </summary>
    /// <param name="dataRequest">Набор стандартных параметров.</param>
    /// <returns>Если проверка не пройдена выпадет ошибка.</returns>
    Task<Auth> AutorizationAsync(AuthDTO dataRequest);

    /// <summary>
    /// Создание\Обновление пользователя.
    /// </summary>
    /// <param name="createUserDTO"></param>
    Task CreateUserAsync(CreateUserDTO createUserDTO);

    /// <summary>
    /// Просмотр входных данных по сотруднику
    /// </summary>
    /// <param name="userId">Ключ сотрудника</param>
    /// <param name="fullList">Вывести весь список?</param>
    /// <returns>Возвращает взодные данные по сотруднику</returns>
    Task<IEnumerable<User>> ViewUserAsync(int userId, bool fullList = false);

    /// <summary>
    /// Изменение создание сотрудников
    /// </summary>
    /// <param name="staff"></param>
    /// <returns></returns>
    Task CreateStaffAsync(Staff staff);

    /// <summary>
    /// Просмотр всех сотрудников
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Staff>> ViewStaffAsync();

    /// <summary>
    /// Просмотр справочников
    /// </summary>
    /// <param name="sprId">Ключ справочника</param>
    /// <returns></returns>
    Task<IEnumerable<Spr>> ViewSprAsync(int sprId);
}
