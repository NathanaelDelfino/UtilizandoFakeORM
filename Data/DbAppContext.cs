using FakeOrm.AzureTables.DependencyInjection;

namespace TestFakeOrm.Data
{
    public class DbAppContext
    {
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.UseAzureTablesRepository(Configuration.GetConnectionString("AzureTableConnection"));
        }
    }
}