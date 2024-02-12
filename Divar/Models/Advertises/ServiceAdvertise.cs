using MongoDB.Bson.Serialization.Attributes;

namespace Models;

public class ServiceAdvertise : Advertise
{
    public ServiceAdvertise() : base()
    {

    }
    public ServiceAdvertise(string title, string price, Location location, List<CategoryObject> categories) : base(title, price, location, categories)
    {

    }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.TimeOfExperience))]
    [MaxLength(Constant.Length.MAX_DESCRIPTION, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string TimeOfExperience { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Professions))]
    [MaxLength(Constant.Length.MAX_DESCRIPTION, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string Professions { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.ServiceRange))]
    [MaxLength(Constant.Length.MAX_DESCRIPTION, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string ServiceRange { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.WorkingHours))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    public string WorkingHourses { get; set; }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.About))]
    public string About { get => Description; set => Description = value; }

}
