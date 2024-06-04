namespace Domain;

public class Category : EntityBase
{
    public string name { get; set; }

    public Category(string name)
    {
        this.name = name;
    }
}
