using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models.Base;
using MongoDB.Bson;
using UnitOfWork;

namespace UnitOfWork.Base
{
    public class Repository<T> : object, IRepository<T> where T : Entity
    {
        internal Repository(DatabaseContext databaseContext): base()
        {
            DatabaseContext = databaseContext ?? throw new ArgumentNullException(paramName: nameof(databaseContext).ToUpper());

            DbSet = DatabaseContext.Set<T>();
        }
        internal DatabaseContext DatabaseContext { get; }
        protected DbSet<T> DbSet { get; }

        public virtual IList<T> GetAll()
        {
            var allEntities = DbSet.ToList();

            return allEntities;
        }

        public virtual async Task<IList<T>> GetAllAsync()
        {
            var allEntities = await DbSet.ToListAsync();

            return allEntities;
        }



        public virtual T GetById(ObjectId id)
        {
            var entity = DbSet.Find(id);
            return entity;
        }

        public virtual async Task<T> GetByIdAsync(ObjectId id)
        {
            var entity = await DbSet.FindAsync(id);
            return entity;
        }



        public virtual void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            DbSet.Add(entity);
        }

        public virtual async Task InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await DbSet.AddAsync(entity);
        }




        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            DbSet.Update(entity);
        }

        public virtual async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await Task.Run( () => 
            {
                DbSet.Update(entity);
            });
        }



        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            DbSet.Remove(entity);
        }

        public virtual async Task DeleteAsync(T entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await Task.Run(() =>
            {
                DbSet.Remove(entity);
            });
        }



        public virtual bool DeleteById(ObjectId id)
        {
            var entity = GetById(id);
            if(entity == null)
            {
                return false;
            }

            Delete(entity);

            return true;
        }

        public virtual async Task<bool> DeleteByIdAsync(ObjectId id)
        {
            var entity = await GetByIdAsync(id);
            if(entity == null)
            {
                return false;
            }

            await DeleteAsync(entity);

            return true;
        }


        public void InsertMany(List<T> entities)
        {
            foreach (var entity in entities)
            {
                Insert(entity);
            }
        }
        public async Task InsertManyAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                await InsertAsync(entity);
            }
        }
    }
}
