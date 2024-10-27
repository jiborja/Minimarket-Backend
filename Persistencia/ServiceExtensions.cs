using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;
using Persistencia.Inventario.Context;

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
            service.AddDbContext<InventarioDbContext>(options => options.UseSqlite(configuration.GetConnectionString("SqlLite")));

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