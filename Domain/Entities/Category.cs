namespace Domain;

public class Category : EntityBase
{
    public string name { get; private set; }

    protected Category(string name)
    {
        this.name = name;
    }
}
