using Microsoft.EntityFrameworkCore;

namespace Models;

[Owned]
public class Facilities
{
    public Facilities() : this(false, false, false)
    {

    }
    public Facilities(bool elevator, bool parking, bool cellar)
    {
        Elevator = elevator;
        Parking = parking;
        Cellar = cellar;
    }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.HasElevator))]
    public bool Elevator { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.HasParking))]
    public bool Parking { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.HasCellar))]
    public bool Cellar { get; set; }
}
