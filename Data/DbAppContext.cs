using FakeOrm.AzureTables.DependencyInjection;
using FakeOrm.AzureTables.Domain;
using FakeOrm.AzureTables.Repositories;
using FakeOrm.AzureTables.Repositories.Interface;
using TestFakeOrm.Domain;

namespace TestFakeOrm.Data
{
    public class DbAppContext 
    {
        public IConfiguration Configuration { get; }
        private readonly IAzureTableRepository<Produto> _ProdutoRepository;

        public DbAppContext(IServiceCollection services)
        {
            ConfigureServices(services);
        }

        public void Save(BaseEntity entity)
        {
            if (entity is Produto)
                _ProdutoRepository.CreateOrUpdateAsync((Produto)entity);
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.UseAzureTablesRepository(Configuration.GetConnectionString("AzureTableConnection"));
        }
    }
}