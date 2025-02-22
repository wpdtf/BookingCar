namespace BookingCar.Api.Infrastructure.Repositories;

public class ClientRepository(DataBaseContext dbContext) : IClientRepository
{
    private readonly DatabaseFacade _dbContext = dbContext.Database;

    public async Task<IEnumerable<Client>> ViewClientAsync(int clientId)
    {
        FormattableString sql = @$"exec dbo.ПросмотрКлиентов
            @clientId = {clientId}";

        return await Task.Run(() => _dbContext.SqlQuery<Client>(sql));
    }

    public async Task EditClientAsync(Client client)
    {
        FormattableString sql = @$"dbo.ИзменениеКлиента
            @JSON = {JsonSerializer.Serialize(client)}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<int> GetExperienceClientAsync(int clientId)
    {
        var sql = @$"SELECT dbo.ф_ПолучитьСтажКлиента({clientId}) AS Experience";

        return Convert.ToInt32((await Task.Run(() => _dbContext.SqlQueryRaw<int?>(sql).ToList()))[0]);
    }
}
