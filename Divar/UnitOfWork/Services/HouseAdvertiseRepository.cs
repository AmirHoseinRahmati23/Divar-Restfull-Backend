using Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.Repositories;
using Models.Base;

namespace UnitOfWork.Services
{
    public class HouseAdvertiseRepository : Repository<Advertise>, IHouseAdvertiseRepository
    {
        internal HouseAdvertiseRepository(DatabaseContext databaseContext) : base(databaseContext)
        {
        }

        public override IList<Advertise> GetAll()
        {
            throw new Exception("Use GetAllHouses, GetAllCars etc...");
        }

        // Houses
        public IList<HouseAdvertise> GetAllHouses()
        {
            var result = DatabaseContext.HouseAdvertises.Where(a => a.Discriminator == nameof(HouseAdvertise)).ToList();

            return result;
        }
        public async Task<IList<HouseAdvertise>> GetAllHousesAsync()
        {
            var result = await DatabaseContext.HouseAdvertises.Where(a => a.Discriminator == nameof(HouseAdvertise)).ToListAsync();

            return result;
        }

        public HouseAdvertise GetHouseById(ObjectId id)
        {
            var result = DatabaseContext.HouseAdvertises.Find(id);

            return result;
        }

        public async Task<HouseAdvertise> GetHouseByIdAsync(ObjectId id)
        {
            var result = await DatabaseContext.HouseAdvertises.FindAsync(id);

            return result;
        }

        public void InsertHouse(HouseAdvertise entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException(paramName: nameof(entity).ToUpper());
            }
            DatabaseContext.HouseAdvertises.Add(entity);
        }

        public async Task InsertHouseAsync(HouseAdvertise entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }
            await DatabaseContext.HouseAdvertises.AddAsync(entity);
        }

        

        public void UpdateHouse(HouseAdvertise entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }
            DatabaseContext.HouseAdvertises.Update(entity);
        }

        public async Task UpdateHouseAsync(HouseAdvertise entity)
        {
            if (entity == null)
            {
                throw new System.ArgumentNullException(paramName: nameof(entity).ToUpper());
            }
            await Task.Run(() => DatabaseContext.HouseAdvertises.Update(entity));
        }

        public void DeleteHouse(HouseAdvertise entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            entity.IsDeleted = true;
        }

        public async Task DeleteHouseAsync(HouseAdvertise entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(paramName: nameof(entity).ToUpper());
            }

            await Task.Run(() =>
            {
                entity.IsDeleted = true;
            });
        }

        public bool DeleteHouseById(ObjectId id)
        {
            var entity = GetHouseById(id);
            if (entity == null)
            {
                return false;
            }

            DeleteHouse(entity);

            return true;
        }

        public async Task<bool> DeleteHouseByIdAsync(ObjectId id)
        {
            var entity = await GetHouseByIdAsync(id);
            if (entity == null)
            {
                return false;
            }

            await DeleteHouseAsync(entity);

            return true;
        }


        ////Cars
        //public IList<CarAdvertise> GetAllCars()
        //{
        //    var result = DatabaseContext.CarAdvertises.Where(a => a.Discriminator == nameof(CarAdvertise)).ToList();

        //    return result;
        //}
        //public async Task<IList<CarAdvertise>> GetAllCarsAsync()
        //{
        //    var result = await DatabaseContext.CarAdvertises.Where(a => a.Discriminator == nameof(CarAdvertise)).ToListAsync();

        //    return result;
        //}

        //// Digital Products
        //public IList<DigitalAdvertise> GetAllDigitalProducts()
        //{
        //    var result = DatabaseContext.DigitalAdvertises.Where(a => a.Discriminator == nameof(DigitalAdvertise)).ToList();

        //    return result;
        //}
        //public async Task<IList<DigitalAdvertise>> GetAllDigitalProductsAsync()
        //{
        //    var result = await DatabaseContext.DigitalAdvertises.Where(a => a.Discriminator == nameof(DigitalAdvertise)).ToListAsync();

        //    return result;
        //}

        //// Services
        //public IList<ServiceAdvertise> GetAllServices()
        //{
        //    var result = DatabaseContext.ServiceAdvertises.Where(a => a.Discriminator == nameof(ServiceAdvertise)).ToList();

        //    return result;
        //}
        //public async Task<IList<ServiceAdvertise>> GetAllServicesAsync()
        //{
        //    var result = await DatabaseContext.ServiceAdvertises.Where(a => a.Discriminator == nameof(ServiceAdvertise)).ToListAsync();

        //    return result;
        //}

        //// Other Objects....
        //public IList<ObjectAdvertise> GetAllOtherObjects()
        //{
        //    var result = DatabaseContext.ObjectAdvertises.Where(a => a.Discriminator == nameof(ObjectAdvertise)).ToList();

        //    return result;
        //}
        //public async Task<IList<ObjectAdvertise>> GetAllOtherObjectsAsync()
        //{
        //    var result = await DatabaseContext.ObjectAdvertises.Where(a => a.Discriminator == nameof(ObjectAdvertise)).ToListAsync();

        //    return result;
        //}
    }

}
