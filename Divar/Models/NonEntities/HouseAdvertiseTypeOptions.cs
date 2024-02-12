using Microsoft.EntityFrameworkCore;
using MongoDB.Bson.Serialization.Attributes;

namespace Models;


public class HouseAdvertiseTypeOptions 
{
    //Buy
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.WholePrice))]
    public string WholePrice { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.PricePerMeter))]
    public string PricePerMeter { get; set; }


    //Rent
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Deposit))]
    public string Deposit { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.MonthlyRent))]
    public string MonthlyRent { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.SuitableFor))]
    public HouseRentSuitableFor SuitableFor { get; set; }

    public enum HouseRentSuitableFor
    {
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Family))]
        Family = 1,
        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FamilyOrSingle))]
            FamilyOrSingle = 2
    }
}


//[BsonDiscriminator(nameof(Discriminator))]
//public class HouseBuyOptions : HouseAdvertiseTypeOptions
//{
//    public HouseBuyOptions()
//    {
//        Discriminator = nameof(HouseBuyOptions);
//    }
//    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.WholePrice))]
//    public string WholePrice { get; set; }
//    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.PricePerMeter))]
//    public string PricePerMeter { get; set; }

//}

//[BsonDiscriminator(nameof(Discriminator))]
//public class HouseRentOptions : HouseAdvertiseTypeOptions
//{
//    public HouseRentOptions()
//    {
//        Discriminator = nameof(HouseRentOptions);
//    }
//    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Deposit))]
//    public string Deposit { get; set; }
//    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.MonthlyRent))]
//    public string MonthlyRent { get; set; }
//    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.SuitableFor))]
//    public HouseRentSuitableFor SuitableFor { get; set; }

//    public enum HouseRentSuitableFor
//    {
//        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Family))]
//        Family = 1,
//        [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FamilyOrSingle))]
//        FamilyOrSingle = 2
//    }
//}

//[BsonDiscriminator(nameof(Discriminator))]
//public class HouseCooperationOptions : HouseAdvertiseTypeOptions 
//{
//    public HouseCooperationOptions()
//    {
//        Discriminator = nameof(HouseCooperationOptions);
//    }
//}
