namespace Models;

public class Location
{
    public Location() : this(string.Empty, string.Empty, string.Empty)
    {
        
    }
    public Location(string cityName, string sectorName, string address) 
    {
        CityName = cityName;
        SectorName = sectorName;
        Address = address;
    }

    public string CityName { get; set; }
    public string SectorName { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Address))]
    public string Address { get; set; }
}