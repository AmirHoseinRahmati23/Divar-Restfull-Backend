using Microsoft.EntityFrameworkCore;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;


public class CarAdvertise : Advertise, IColored, IBranded
{
    public CarAdvertise() : this(string.Empty, string.Empty, new Location(), [])
    {
        
    }
    public CarAdvertise(string title, string price, Location location, List<CategoryObject> categories) : base(title, price, location, categories)
    {
        
    }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.Brand))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages)
        , ErrorMessageResourceName = nameof(ErrorMessages.Required))]
    [ForeignKey(nameof(BrandId))]
    public string Brand { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CarModel))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages)
        , ErrorMessageResourceName = nameof(ErrorMessages.Required))]
    public int Model { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.Color))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages)
        , ErrorMessageResourceName = nameof(ErrorMessages.Required))]
    [ForeignKey(nameof(ColorId))]
    public string Color { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.AgePerKilometer))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string AgePerKilometer { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.CarBodyStatus))]
    public CarBodyStatus BodyStatus { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.AdditionalInfo))]
    public CarAdditionalInfo AdditionalInfo { get; set; }

    
    public ObjectId BrandId { get; set; }
    public ObjectId ColorId { get; set; }


}
