using Models.Base;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitOfWork
{
    public class Repository<T> : Base.Repository<T> where T : Entity
    {
        internal Repository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }



        public override T GetById(ObjectId id)
        {
            var entity = DbSet.Find(id);
            return entity;
        }

        public override async Task<T> GetByIdAsync(ObjectId id)
        {
            var entity = await DbSet.FindAsync(id);
            return entity;
        }


        public override void Delete(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            entity.IsDeleted = true;
            Update(entity);
        }

        public override async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            entity.IsDeleted = true;
            await UpdateAsync(entity);
        }



        public override bool DeleteById(ObjectId id)
        {
            var entity = GetById(id);
            if (entity == null)
            {
                return false;
            }

            Delete(entity);

            return true;
        }

        public override async Task<bool> DeleteByIdAsync(ObjectId id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

            await DeleteAsync(entity);
            
            return true;

        }

        
    }
}
