
using Microsoft.EntityFrameworkCore;

namespace Models;

[Owned]
public class CategoryObject : ITitled
{
    public CategoryObject()
    {
        Id = ObjectId.Empty;
        Title = string.Empty;
    }
    public CategoryObject(ObjectId id, string title)
    {
        Id = id;
        Title = title;
    }

    public ObjectId Id { get; set; }
    public string Title { get; set; }
}
