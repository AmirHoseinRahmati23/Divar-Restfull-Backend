using Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Base;

namespace UnitOfWork.Repositories
{
    public interface IHouseAdvertiseRepository : IRepository<Advertise>
    {
        // House
        public IList<HouseAdvertise> GetAllHouses();
        public Task<IList<HouseAdvertise>> GetAllHousesAsync();
        public HouseAdvertise GetHouseById(ObjectId id);
        public Task<HouseAdvertise> GetHouseByIdAsync(ObjectId id);
        public void InsertHouse(HouseAdvertise entity);
        public Task InsertHouseAsync(HouseAdvertise entity);

        public void UpdateHouse(HouseAdvertise entity);
        public Task UpdateHouseAsync(HouseAdvertise entity);

        public void DeleteHouse(HouseAdvertise entity);
        public Task DeleteHouseAsync(HouseAdvertise entity);
        public bool DeleteHouseById(ObjectId id);
        public Task<bool> DeleteHouseByIdAsync(ObjectId id);



        //public IList<CarAdvertise> GetAllCars();
        //public Task<IList<CarAdvertise>> GetAllCarsAsync();
        //public IList<DigitalAdvertise> GetAllDigitalProducts();
        //public Task<IList<DigitalAdvertise>> GetAllDigitalProductsAsync();
        //public IList<ServiceAdvertise> GetAllServices();
        //public Task<IList<ServiceAdvertise>> GetAllServicesAsync();
        //public IList<ObjectAdvertise> GetAllOtherObjects();
        //public Task<IList<ObjectAdvertise>> GetAllOtherObjectsAsync();
    }
}
