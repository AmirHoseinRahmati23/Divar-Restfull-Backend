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
    public void AddingCityToMongoDBDatabase_Test()
    {
        var city = new City("Tehran", [new Sector("TehranUniversity"), new Sector("TehranLake")]);
        
        UnitOfWork.CityRepository.Insert(city);
        UnitOfWork.Save();

        var result = UnitOfWork.CityRepository.GetById(city.Id);
        Assert.NotNull(result);
        Assert.Equal(city, result);
    }
    [Fact]
    public void AddingCategoryToDatabase_Test()
    {
        var cat = new Category("Services", [new Category("Programming", [new Category("Web")]), new Category("IT")]);
        UnitOfWork.CategoryRepository.Insert(cat);
        UnitOfWork.Save();

        var category = UnitOfWork.CategoryRepository.GetById(cat.Id);


        Assert.Equal(cat, category);
    }

    [Fact]
    public void AddingColorToDatabase_Test()
    {
        var color = new ProductColor("Black", "#000000");

        UnitOfWork.ColorRepository.Insert(color);
        UnitOfWork.Save();

        var result = UnitOfWork.ColorRepository.GetById(color.Id);

        Assert.NotNull(result);
        Assert.Equal(color, result);
    }

    [Fact]
    public void AddingBrandToDatabase_Test()
    {
        var brand = new Brand("Huawiii", [new SubBrand("Huawi Galaxy S12 Pro!"), new SubBrand("Huawii Note 12 Pro"), new SubBrand("Huawi 14 Pro Max")]);

        UnitOfWork.BrandRepository.Insert(brand);
        UnitOfWork.Save();

        var result = UnitOfWork.BrandRepository.GetById(brand.Id);

        Assert.NotNull(result);
        Assert.Equal(brand, result);
    }

    [Fact]
    public void AddingServiceAdvertiseToDatabase_Test()
    {
        var allCategories = UnitOfWork.CategoryRepository.GetAll();
        var city = UnitOfWork.CityRepository.GetAll()[0];

        var advertise = new ServiceAdvertise("Programming Web Applications", "Depends", new Location(city.Title, city.Sectors[0].Title, "Khiabane Folan"), [ new CategoryObject(), new CategoryObject() ]);

        UnitOfWork.AdvertiseRepository.Insert(advertise);
        UnitOfWork.Save();

        var result = UnitOfWork.AdvertiseRepository.GetById(advertise.Id);


        Assert.NotNull(result);
        Assert.Equal(advertise, result);


    }

    [Fact]
    public void AddingHomeAdvertiseToDatabase_Test()
    {
        var allCategories = UnitOfWork.CategoryRepository.GetAll();
        var city = UnitOfWork.CityRepository.GetAll()[0];

        var advertise = new HouseAdvertise(HouseAdvertiseType.Buy, new HouseAdvertiseTypeOptions() { WholePrice = "Depends" , PricePerMeter = "Very Depends"}
        , new Location("Tehran" , "Markaz" , "Markaze Tehran"), [new CategoryObject(), new CategoryObject()] 
        , new Facilities(false,true,true), HouseType.Mansion, 6, 3, 1200, 1401, title: "Vilaye Lavasan :)", price: "Kheily")
        {
            Images = [new Image("folan") , new Image("bahman")],
            Description = "keily keily Koob",
            FloorNumber = 1,
        };

        UnitOfWork.HouseAdRepository.Insert(advertise);
        UnitOfWork.Save();

        var result = UnitOfWork.HouseAdRepository.GetById(advertise.Id);

        Assert.NotNull(result);
        Assert.NotNull(advertise.AdvertiseOptions);
        Assert.Equal(advertise.AdvertiseOptions, result.AdvertiseOptions);
    }

    [Fact]
    public void AddingDigitalAdvertiseToDatabase_Test()
    {
        var allCategories = UnitOfWork.CategoryRepository.GetAll();
        var city = UnitOfWork.CityRepository.GetAll()[0];
        var color = UnitOfWork.ColorRepository.GetAll()[0];
        var brand = UnitOfWork.BrandRepository.GetAll()[0];
        var advertise = new DigitalAdvertise("Galexy Huawi Note 8 Pro Max", "100,000,000,000"
            , new Location("Tehran", "Markazesh", "Khiaban Balashahr"), [new CategoryObject(), new CategoryObject()])
        {
            Images = [new Image("folan"), new Image("bahman")],
            Description = "keily keily Khoob",
            Cpu = "CPUye Hwawii Ghavi!!!",
            Ram = "12489 TB!!!!!!",
            Color = color,
            Status = ObjectStatus.GoodAsNew,
            OperatingSystem = "WinMacAndroidPhone",
            Brand = brand
        };

        UnitOfWork.AdvertiseRepository.Insert(advertise);
        UnitOfWork.Save();



    }

}