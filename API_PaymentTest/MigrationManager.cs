using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DbContextLaye;
namespace PaymentTest
{
    public static class MigrationManager
    {
        public static IHost MigrationDataBase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            using (var appCtx = scope.ServiceProvider.GetRequiredService<DbContextData>())
            {
                appCtx.Database.EnsureCreated();
            }
            return host;
        }
    }
}
