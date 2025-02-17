namespace BookingCar.Api.Infrastructure.Repositories;

public class GeneralRepository : DbContext, IGeneralRepository
{
    public GeneralRepository(DbContextOptions<GeneralRepository> configure) : base(configure)
    {
    }

    public async Task AutorizationAsync(DataRequestDto dataRequest)
    {
        FormattableString sql = @$"dbo.Авторизация 
            @login = {dataRequest.ClientId}, @password = {dataRequest.LoanId}";

        var result = await Task.Run(() => Database.SqlQuery<string>(sql).AsEnumerable().First());
    }
}
