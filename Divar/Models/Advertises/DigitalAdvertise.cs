using MongoDB.Bson.Serialization.Attributes;

namespace Models;


public class DigitalAdvertise : ObjectAdvertise
{
    public DigitalAdvertise() : base()
    {

    }
    public DigitalAdvertise(string title, string price, Location location, List<CategoryObject> category) : base(title, price, location, category)
    {

    }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.CPU))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string Cpu { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ScreenSize))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string ScreenSize { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.OperatingSystem))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string OperatingSystem { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.MemorySize))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string MemorySize { get; set;}
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.RAM))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string Ram { get; set; }

}
