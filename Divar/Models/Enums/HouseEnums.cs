namespace Models.Enums;

public enum HouseAdvertiseType
{
    Buy = 1,
    Rent = 2,
    Cooperation = 3
}
public enum HouseType
{
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Apartment))]
    Apartment = 1,
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Mansion))]
    Mansion = 2,
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Store))]
    Store = 3
}
