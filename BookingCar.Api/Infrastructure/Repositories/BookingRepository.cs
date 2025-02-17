namespace BookingCar.Api.Infrastructure.Repositories;

public class BookingRepository : DbContext, IBookingRepository
{
    public BookingRepository(DbContextOptions<GeneralRepository> configure) : base(configure)
    {
    }

    public async Task<IEnumerable<Car>> ViewCarAsync()
    {
        FormattableString sql = @$"dbo.ПросмотрАвтомобилей";

        return await Task.Run(() => Database.SqlQuery<Car>(sql));
    }

    public async Task EditCarAsync(Car car)
    {
        FormattableString sql = @$"dbo.ИзменениеАвтомобиля 
            @JSON = {JsonSerializer.Serialize(car)}";

        await Database.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Tariff>> ViewTariffAsync()
    {
        FormattableString sql = @$"dbo.ПросмотрТарифов";

        return await Task.Run(() => Database.SqlQuery<Tariff>(sql));
    }

    public async Task EditTariffAsync(Tariff tariff)
    {
        FormattableString sql = @$"dbo.ИзменениеТарифов 
            @JSON = {JsonSerializer.Serialize(tariff)}";

        await Database.ExecuteSqlAsync(sql);
    }

    public async Task EditTariffToCarAsync(int tariffId, int carId)
    {
        FormattableString sql = @$"dbo.ДобавлениеУдалениеТарифаАвто
            @tariffId = {tariffId}, @carId = {carId}";

        await Database.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Booking>> ViewBookingAsync(int bookingId)
    {
        FormattableString sql = @$"dbo.ПросмотрБронирования 
            @bookingId = {bookingId}";

        return await Task.Run(() => Database.SqlQuery<Booking>(sql));
    }

    public async Task EditBookingAsync(Booking booking)
    {
        FormattableString sql = @$"dbo.ИзменениеБронирования 
            @JSON = {JsonSerializer.Serialize(booking)}";

        await Database.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Incident>> ViewIncidentAsync(int incidentId)
    {
        FormattableString sql = @$"dbo.ПросмотрИнцидента 
            @incidentId = {incidentId}";

        return await Task.Run(() => Database.SqlQuery<Incident>(sql));
    }

    public async Task EditIncidentAsync(Incident incident)
    {
        FormattableString sql = @$"dbo.ИзменениеИнцидента 
            @JSON = {JsonSerializer.Serialize(incident)}";

        await Database.ExecuteSqlAsync(sql);
    }
}
