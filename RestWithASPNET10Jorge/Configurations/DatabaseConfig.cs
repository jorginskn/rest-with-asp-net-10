using Microsoft.EntityFrameworkCore;
using RestWithASPNET9Jorge.Model.Context;

namespace RestWithASPNET9Jorge.Configurations;

public static class DatabaseConfig
{
    public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];
        if(connectionString == null) {
            throw new ArgumentNullException("ConnectionString não encontrada na configuração.");
        }
        services.AddDbContext<MSSQLContext>(options => options.UseSqlServer(connectionString));
        return services;
    }
}
