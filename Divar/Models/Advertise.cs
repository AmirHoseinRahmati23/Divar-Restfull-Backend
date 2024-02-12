using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

[BsonDiscriminator(RootClass = true)]
[BsonKnownTypes([typeof(CarAdvertise), typeof(HouseAdvertise), typeof(DigitalAdvertise), typeof(ServiceAdvertise), typeof(ObjectAdvertise)])]
public class Advertise : ActivableEntity, ITitled
{
    public Advertise() : this(string.Empty, string.Empty, new Location(), []) 
    { 
    
    }
    public Advertise(string title, string price, Location location, List<CategoryObject> categories) : base()
    {
        Title = title;
        Price = price;
        Location = location;
        Categories = categories;
    }

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Title))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessage = nameof(ErrorMessages.Required))]
    [MaxLength(Constant.Length.MAX_TITLE , ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    [MinLength(Constant.Length.MIN_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MinLength))]
    public string Title { get; set; }


    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Price))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessage = nameof(ErrorMessages.Required))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string Price { get; set; }


    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Image))]
    public List<Image> Images { get; set; }


    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Description))]
    [MaxLength(Constant.Length.MAX_DESCRIPTION, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string Description { get; set; }

    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Location))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessage = nameof(ErrorMessages.Required))]
    public Location Location { get; set; }


    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Categories))]
    [Required(ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessage = nameof(ErrorMessages.Required))]
    public List<CategoryObject> Categories { get; set; }


    public string Discriminator { get; set; }

    public string PhoneNumber { get; set; }
}
