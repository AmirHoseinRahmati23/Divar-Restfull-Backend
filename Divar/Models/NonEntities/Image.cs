using Microsoft.EntityFrameworkCore;

namespace Models;

[Owned]
public class Image: ITitled
{
    public Image() : this(string.Empty)
    {
        
    }
    public Image(string title)
    {
        Title = title;
    }
    public string Title { get; set; }

    public string FileExtension { get; set; }

}
