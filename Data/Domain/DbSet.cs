using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using FakeOrm.AzureTables.Configurations;
using FakeOrm.AzureTables.Domain;
using FakeOrm.AzureTables.Repositories;
using TestFakeOrm.Domain;

namespace UtilizandoFakeORM.Data.Domain
{
    public class DbSet<TEntity> where TEntity : class
    {
        private List<TEntity> _lista;

        public DbSet()
        {
            _lista = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _lista.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _lista.Remove(entity);
        }

        public void Save(ConnectionStrings connectionStrings)
        {
            var repository = new AzureTableRepository<TEntity>(connectionStrings);
            foreach (var item in _lista)
                repository.CreateOrUpdateAsync(item);

        }
    }
}