namespace Models.Base;

public abstract class Entity : object
{
    public Entity() : base()
    {
        Id = ObjectId.GenerateNewId();
        IsDeleted = false;
    }

    [Key]
    [Display(ResourceType = typeof(DataDictionary),
        Name = nameof(DataDictionary.Id))]
    public ObjectId Id { get; set; }


    public bool IsDeleted { get; set; }


}
