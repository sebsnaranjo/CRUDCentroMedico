using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using CentroMedico.BL.Data;

namespace CentroMedico.BL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly CentroMedicoContext CentroMedicoContext;

        public GenericRepository(CentroMedicoContext CentroMedicoContext)
        {
            this.CentroMedicoContext = CentroMedicoContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            CentroMedicoContext.Set<TEntity>().Remove(entity);
            await CentroMedicoContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await CentroMedicoContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await CentroMedicoContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            CentroMedicoContext.Set<TEntity>().Add(entity);
            await CentroMedicoContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            //CentroMedicoContext.Entry(entity).State = EntityState.Modified;
            CentroMedicoContext.Set<TEntity>().AddOrUpdate(entity);
            await CentroMedicoContext.SaveChangesAsync();
            return entity;
        }
    }
}
