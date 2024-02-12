namespace Models.Base;

public abstract class ExtendedEntity : Entity
{
    /* Contains: 
     * 1-UpdateDateTime Property 
     * 2-InsertTime Property
     * 3-......
     */
    public ExtendedEntity() : base()
    {
        InsertTime = Utility.Now;
        UpdateTime = Utility.Now;
    }


    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.InsertDateTime))]
    public DateTime InsertTime { get; set; }

    [Display(ResourceType = typeof(DataDictionary)
        , Name = nameof(DataDictionary.UpdateDateTime))]
    public DateTime UpdateTime { get; set; }
}
