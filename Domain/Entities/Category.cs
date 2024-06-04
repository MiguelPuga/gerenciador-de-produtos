namespace Domain;

public class Category : EntityBase
{
    public string name { get; set; }

    protected Category(string name)
    {
        this.name = name;
    }
}
