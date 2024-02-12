using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Base;
using MongoDB.Bson;

namespace UnitOfWork.Base
{
    public interface IRepository<T> where T : Entity
    {
        public IList<T> GetAll();
        public Task<IList<T>> GetAllAsync();

        // ObjectId Input In Case Of MongoDB
        public T GetById(ObjectId id);

        // ObjectId Input In Case Of MongoDB
        public Task<T> GetByIdAsync(ObjectId id);

        public void Insert(T entity);
        public Task InsertAsync(T entity);

        public void InsertMany(List<T> entities);
        public Task InsertManyAsync(List<T> entities);

        public void Update(T entity);
        public Task UpdateAsync(T entity);

        public void Delete(T entity);
        public Task DeleteAsync(T entity);

        // ObjectId Input In Case Of MongoDB
        public bool DeleteById(ObjectId id);
        // ObjectId Input In Case Of MongoDB
        public Task<bool> DeleteByIdAsync(ObjectId id);
    }
}
