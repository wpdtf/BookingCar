namespace BookingCar.Api.Domain.Interface;

public interface IBookingRepository
{
    /// <summary>
    /// Просмотр всех автомобилей
    /// </summary>
    /// <param name="carId">Или одного</param>
    /// <param name="onlyActive">Исключительно активные автомобили</param>
    Task<IEnumerable<Car>> ViewCarAsync(int carId, bool onlyActive);

    /// <summary>
    /// Редактирование автомобилей
    /// </summary>
    /// <param name="car">Какого автомобиля</param>
    Task EditCarAsync(Car car);

    /// <summary>
    /// Просмотр всех тарифов
    /// </summary>
    /// <param name="tariffId">Или одного</param>
    Task<IEnumerable<Tariff>> ViewTariffAsync(int tariffId);

    /// <summary>
    /// Редактирование тарифов
    /// </summary>
    /// <param name="tariff">Какого тарифа</param>
    Task EditTariffAsync(Tariff tariff);

    /// <summary>
    /// Редактирование связи тарифа и автомобиля
    /// </summary>
    /// <param name="tariffId">Какого тарифа</param>
    /// <param name="carId">Какого автомобиля</param>
    Task EditTariffToCarAsync(int tariffId, int carId);

    /// <summary>
    /// Просмотр связи тарифа и автомобиля
    /// </summary>
    /// <param name="carId"></param>
    Task<IEnumerable<Tariff>> ViewTariffToCarAsync(int carId);

    /// <summary>
    /// Просмотр всех бронирований
    /// </summary>
    /// <param name="bookingId">Или одного</param>
    /// <param name="clientId">по определенному клиенту</param>
    Task<IEnumerable<Booking>> ViewBookingAsync(int bookingId, int clientId);

    /// <summary>
    /// Редактирование бронирования
    /// </summary>
    /// <param name="booking">Какого бронирования</param>
    Task EditBookingAsync(Booking booking);

    /// <summary>
    /// Просмотр инцидиентов
    /// </summary>
    /// <param name="incidentId">Или одного</param>
    Task<IEnumerable<Incident>> ViewIncidentAsync(int incidentId);

    /// <summary>
    /// Редактирование инцидента
    /// </summary>
    /// <param name="incident">Какого ицидента</param>
    Task EditIncidentAsync(Incident incident);

    /// <summary>
    /// Получить клиентов подходящих к автомобилю
    /// </summary>
    /// <param name="carId">Автомобиль</param>
    Task<IEnumerable<Client>> ViewClientToCarAsync(int carId);
}
