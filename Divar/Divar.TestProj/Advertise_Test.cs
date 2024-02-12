using Microsoft.EntityFrameworkCore;
using Models;
using Models.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using UnitOfWork;
using UnitOfWork.Tools;
using UnitOfWork.Tools.Enums;

namespace Divar.Server;

public class AdvertiseMongo_Test
{
    public AdvertiseMongo_Test()
    {
        var options = new Options()
        {
            Provider = Provider.MongoDB,
            ConnectionString = "mongodb://localhost:27017",
            DatabaseName = "DivarRestFullTest"
        };

        UnitOfWork = new UnitOfWork.UnitOfWork(options: options);
    }

    public UnitOfWork.UnitOfWork UnitOfWork { get; set; }


    [Fact]
    public void GettingAllHouseAdvertises_Test()
    {
        
        var houseAdvertises = UnitOfWork.HouseAdvertiseRepo.GetAllHouses();
        var houseAdvertises2 = UnitOfWork.HouseAdvertiseRepo.GetAllHouses();
        
        Assert.Equal(houseAdvertises, houseAdvertises2);
    }

    [Fact]
    public void AddingHomeAdvertiseToDatabase_Test()
    {

        var advertise = new HouseAdvertise(HouseAdvertiseType.Buy, new HouseAdvertiseTypeOptions() { WholePrice = "Depends" , PricePerMeter = "Very Depends"}
        , new Location("Tehran" , "Markaz" , "Markaze Tehran"), [new CategoryObject(), new CategoryObject()] 
        , new Facilities(false,true,true), HouseType.Mansion, 6, 3, 1200, 1401, title: "Vilaye Lavasan :)", price: "Kheily")
        {
            Images = [new Image("folan") , new Image("bahman")],
            Description = "keily keily Koob",
            FloorNumber = 1,
        };

        UnitOfWork.HouseAdvertiseRepo.Insert(advertise);
        UnitOfWork.Save();

        HouseAdvertise result = UnitOfWork.HouseAdvertiseRepo.GetHouseById(advertise.Id);

        Assert.NotNull(result);
        Assert.NotNull(advertise.AdvertiseOptions);
        Assert.Equal(advertise.AdvertiseOptions, result.AdvertiseOptions);
    }


}