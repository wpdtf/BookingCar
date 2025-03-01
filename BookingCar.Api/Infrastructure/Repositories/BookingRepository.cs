namespace BookingCar.Api.Infrastructure.Repositories;

public class BookingRepository(DataBaseContext dbContext) : IBookingRepository
{
    private readonly DatabaseFacade _dbContext = dbContext.Database;

    public async Task<IEnumerable<Car>> ViewCarAsync(int carId)
    {
        FormattableString sql = @$"dbo.ПросмотрАвтомобилей @carId = {carId}";

        return await Task.Run(() => _dbContext.SqlQuery<Car>(sql));
    }

    public async Task EditCarAsync(Car car)
    {
        FormattableString sql = @$"dbo.ИзменениеАвтомобиля 
            @JSON = {JsonSerializer.Serialize(car)}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Tariff>> ViewTariffAsync(int tariffId)
    {
        FormattableString sql = @$"dbo.ПросмотрТарифов @tariffId = {tariffId}";

        return await Task.Run(() => _dbContext.SqlQuery<Tariff>(sql));
    }

    public async Task EditTariffAsync(Tariff tariff)
    {
        FormattableString sql = @$"dbo.ИзменениеТарифов 
            @JSON = {JsonSerializer.Serialize(tariff)}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task EditTariffToCarAsync(int tariffId, int carId)
    {
        FormattableString sql = @$"dbo.ДобавлениеУдалениеТарифаАвто
            @tariffId = {tariffId}, @carId = {carId}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Tariff>> ViewTariffToCarAsync(int tariffId, int carId)
    {
        FormattableString sql = @$"dbo.ПросмотрТарифаИАвто 
            @tariffId = {tariffId}, @carId = {carId}";

        return await Task.Run(() => _dbContext.SqlQuery<Tariff>(sql));
    }

    public async Task<IEnumerable<Booking>> ViewBookingAsync(int bookingId)
    {
        FormattableString sql = @$"dbo.ПросмотрБронирования 
            @bookingId = {bookingId}";

        return await Task.Run(() => _dbContext.SqlQuery<Booking>(sql));
    }

    public async Task EditBookingAsync(Booking booking)
    {
        FormattableString sql = @$"dbo.ИзменениеБронирования 
            @JSON = {JsonSerializer.Serialize(booking)}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Incident>> ViewIncidentAsync(int incidentId)
    {
        FormattableString sql = @$"dbo.ПросмотрИнцидента 
            @incidentId = {incidentId}";

        return await Task.Run(() => _dbContext.SqlQuery<Incident>(sql));
    }

    public async Task EditIncidentAsync(Incident incident)
    {
        FormattableString sql = @$"dbo.ИзменениеИнцидента 
            @JSON = {JsonSerializer.Serialize(incident)}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Client>> ViewClientToCarAsync(int carId)
    {
        FormattableString sql = @$"dbo.ПолучитьКлиентовДляАвто 
            @carId = {JsonSerializer.Serialize(carId)}";

        return await Task.Run(() => _dbContext.SqlQuery<Client>(sql));
    }
}
