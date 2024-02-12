namespace Models.Base;

public abstract class ActivableEntity: ExtendedEntity, IActivable
{
    public ActivableEntity() : base()
    {
        IsActive = true;
    }
    [Display(ResourceType = typeof(DataDictionary), Name = nameof(DataDictionary.IsActive))]
    public bool IsActive { get; set; }
}
