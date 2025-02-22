namespace BookingCar.Api.Infrastructure.Repositories;

public class ReportRepository(DataBaseContext dbContext) : IReportRepository
{
    private readonly DatabaseFacade _dbContext = dbContext.Database;

    public async Task<IEnumerable<ReportForClientBooking>> ViewClientBookingAsync(int clientId)
    {
        FormattableString sql = @$"exec dbo.ОтчетАрендаКлиента
            @clientId = {clientId}";

        return await Task.Run(() => _dbContext.SqlQuery<ReportForClientBooking>(sql));
    }

    public async Task<IEnumerable<ReportForClientIncident>> ViewClientIncidentAsync(int clientId)
    {
        FormattableString sql = @$"exec dbo.ОтчетИнфидентовКлиента
            @clientId = {clientId}";

        return await Task.Run(() => _dbContext.SqlQuery<ReportForClientIncident>(sql));
    }

    public async Task<IEnumerable<ReportForClientBooking>> ViewCarBookingAsync(int carId)
    {
        FormattableString sql = @$"exec dbo.ОтчетАрендаАвто
            @carId = {carId}";

        return await Task.Run(() => _dbContext.SqlQuery<ReportForClientBooking>(sql));
    }

    public async Task<IEnumerable<ReportForClientIncident>> ViewCarIncidentAsync(int carId)
    {
        FormattableString sql = @$"exec dbo.ОтчетИнфидентовАвто
            @carId = {carId}";

        return await Task.Run(() => _dbContext.SqlQuery<ReportForClientIncident>(sql));
    }
}
