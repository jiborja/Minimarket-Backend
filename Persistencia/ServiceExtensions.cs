using Persistencia.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistencia.Repository;
using Persistencia.Contexts;

namespace Persistencia
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection service, IConfiguration configuration)
        {

            // service.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
            //     configuration.GetConnectionString("SqlServer"),
            //     b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            // ));
            service.AddDbContext<InventarioDbContext>(options => options.UseSqlite(configuration.GetConnectionString("Sqlite")));

            #region Repositories
            service.AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>));
            #endregion

            #region  Caching
            // service.AddStackExchangeRedisCache(options =>
            // {
            //     options.Configuration = configuration.GetValue<string>("Caching:RedisServer") + ":" + configuration.GetValue<string>("Caching:RedisPort");

            // });
            #endregion
        }
    }
}