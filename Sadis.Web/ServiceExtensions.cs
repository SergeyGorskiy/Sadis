using Microsoft.EntityFrameworkCore;
using Sadis.DAL.Data;

namespace Sadis.Web
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<SmetaContext>(options =>
            options.UseSqlServer(config.GetConnectionString("SmetaContextConnection")));
        }
    }
}
