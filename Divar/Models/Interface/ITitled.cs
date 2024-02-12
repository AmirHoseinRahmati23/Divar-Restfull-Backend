namespace Models.Interface;

public interface ITitled
{
    [Required(ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessage = nameof(ErrorMessages.Required))]
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.Title))]
    [MaxLength(Constant.Length.MAX_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MaxLength))]
    [MinLength(Constant.Length.MIN_TITLE, ErrorMessageResourceType = typeof(ErrorMessages),
        ErrorMessageResourceName = nameof(ErrorMessages.MinLength))]
    public string Title { get; set; }
}
