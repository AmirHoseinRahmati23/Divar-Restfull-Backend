using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class ObjectAdvertise : Advertise, IColored, IBranded
{
    public ObjectAdvertise(string title, string price, Location location, List<CategoryObject> categories) : base(title, price, location, categories)
    {
        
    }
    public ObjectAdvertise() : base()
    {
        
    }
    [ForeignKey(nameof(BrandId))]
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Brand))]
    public string Brand { get; set; }
    [ForeignKey(nameof(ColorId))]
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Color))]
    public string Color { get; set; }

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Status))]
    public ObjectStatus Status { get; set; }

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.CanBeExchanged))]
    public bool CanBeExchanged { get; set; }

    public ObjectId BrandId { get; set; }
    public ObjectId ColorId { get; set; }

}


