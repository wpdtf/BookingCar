namespace BookingCar.Api.Domain.Interface;

public interface IClientRepository
{
    /// <summary>
    /// Получение клиента или списка
    /// </summary>
    /// <param name="clientId">По какому клиенту.</param>
    /// <returns>Если проверка не пройдена выпадет ошибка.</returns>
    Task<IEnumerable<Client>> ViewClientAsync(int clientId);

    /// <summary>
    /// Изменение клиента
    /// </summary>
    /// <param name="client">Какие данные нужно указать</param>
    /// <returns>Если проверка не пройдена выпадет ошибка.</returns>
    Task EditClientAsync(Client client);

    /// <summary>
    /// Получить отдельно стаж вождения клиента
    /// </summary>
    /// <param name="clientId">По какому клиенту</param>
    /// <returns>Стаж в годах</returns>
    Task<int> GetExperienceClientAsync(int clientId);

    /// <summary>
    /// Авторизация клиента
    /// </summary>
    /// <param name="authDTO">Данные для авторизации</param>
    Task<Client> AutorizationAsync(AuthDTO authDTO);

    /// <summary>
    /// Изменение данных для авторизации клиентом
    /// </summary>
    /// <param name="createUserDTO">Входные данные для указания</param>
    Task CreateUserAsync(CreateUserDTO createUserDTO);

    /// <summary>
    /// Вернем список логинов клиента
    /// </summary>
    /// <param name="userId">какой клиент</param>
    Task<IEnumerable<User>> ViewUserAsync(int userId);
}
