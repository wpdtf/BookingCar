namespace BookingCar.Api.Infrastructure.Repositories;

public class GeneralRepository(DataBaseContext dbContext) : IGeneralRepository
{
    private readonly DatabaseFacade _dbContext = dbContext.Database; 

    public async Task<Auth> AutorizationAsync(AuthDTO authDTO)
    {
        FormattableString sql = @$"dbo.Авторизация 
            @login = {authDTO.Login}, @password = {authDTO.Password}";

        return await Task.Run(() => _dbContext.SqlQuery<Auth>(sql).AsEnumerable().First());
    }

    public async Task CreateUserAsync(CreateUserDTO createUserDTO)
    {
        FormattableString sql = @$"dbo.ИзменениеПользователя 
            @login = {createUserDTO.Login}, @password = {createUserDTO.Password}, @userId = {createUserDTO.UserId}, @dateLastActual = {createUserDTO.DateLactActual}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<User>> ViewUserAsync(int userId, bool fullList = false)
    {
        FormattableString sql = @$"dbo.ПросмотрПользователя 
            @userId = {userId}, @fullList = {fullList}";

        return await Task.Run(() => _dbContext.SqlQuery<User>(sql));
    }

    public async Task CreateStaffAsync(Staff staff)
    {
        FormattableString sql = @$"dbo.ИзменениеСотрудника 
            @JSON = {JsonSerializer.Serialize(staff)}";

        await _dbContext.ExecuteSqlAsync(sql);
    }

    public async Task<IEnumerable<Staff>> ViewStaffAsync()
    {
        FormattableString sql = @$"dbo.ПросмотрСотрудников";

        return await Task.Run(() => _dbContext.SqlQuery<Staff>(sql));
    }

    public async Task<IEnumerable<Spr>> ViewSprAsync(int sprId)
    {
        FormattableString sql = @$"dbo.ПросмотрСправочников @sprId = {sprId}";

        return await Task.Run(() => _dbContext.SqlQuery<Spr>(sql));
    }
}
