using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;

namespace Models;


public class HouseAdvertise : Advertise
{
    #region Constructors
    public HouseAdvertise() : this(HouseAdvertiseType.Cooperation, new HouseAdvertiseTypeOptions()) { }
    public HouseAdvertise(HouseAdvertiseType advertiseType, HouseAdvertiseTypeOptions advertiseOptions)
        : this(string.Empty, string.Empty, new Location(), new List<CategoryObject>(), advertiseType, advertiseOptions) { }
    public HouseAdvertise
        (HouseAdvertiseType advertiseType, HouseAdvertiseTypeOptions advertiseOptions,
        Location location, List<CategoryObject> categories,
        Facilities hasFacilities = null, HouseType type = default,
        int numberOfRooms = default, int numberOfFloors = default,
        int meterage = default, int cunstructionYear = default,
        int floorNumber = default, string title = "", string price = "")

        : this(title: title, price, location,
              categories, advertiseType, advertiseOptions)
    {
        Meterage = meterage;
        ConstructionYear = cunstructionYear;
        NumberOfRooms = numberOfRooms;
        NumberOfFloors = numberOfFloors;
        FloorNumber = floorNumber;
        HouseType = type;
        AdvertiseType = advertiseType;
        HasFacilities = hasFacilities;
        Location = (location == null) ? new Location() : location;
    }
    public HouseAdvertise(string title, string price, Location location, List<CategoryObject> categories
        , HouseAdvertiseType advertiseType, HouseAdvertiseTypeOptions advertiseOptions) : base(title, price, location, categories)
    {
        AdvertiseOptions = advertiseOptions;
        AdvertiseType = advertiseType;
    }
    #endregion

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Meterage))]
    [Range(Constant.Length.MIN_METERAGE ,Constant.Length.MAX_METERAGE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public int Meterage { get; set; }

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ConstructionYear))]
    [Range(Constant.Length.MIN_CONSTRUCTION_YEAR, Constant.Length.MAX_CONSTRUCTION_YEAR, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public int ConstructionYear { get; set; }

    [Range(Constant.Length.MIN_FLOOR_NUMBER, Constant.Length.MAX_FLOOR_NUMBER, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.NumberOfRooms))]
    public int NumberOfRooms { get; set; }
    
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.NumberOfFloors))]
    [Range(Constant.Length.MIN_FLOOR_NUMBER, Constant.Length.MAX_FLOOR_NUMBER, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public int NumberOfFloors { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.FloorNumber))]
    [Range(Constant.Length.MIN_FLOOR_NUMBER, Constant.Length.MAX_FLOOR_NUMBER, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public int FloorNumber { get; set; }

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Facilities))]
    public Facilities HasFacilities { get; set; }


    public HouseAdvertiseType AdvertiseType { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.HouseType))]
    public HouseType HouseType { get; set; }


    public HouseAdvertiseTypeOptions AdvertiseOptions { get; set; }

}




