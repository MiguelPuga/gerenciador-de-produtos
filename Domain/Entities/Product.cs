namespace Domain;

public class Product : EntityBase
{
    public string name { get; private set; }
    public Price price { get; private set; }

    public Product (string name, Price price)
    {
        this.name = name;
        this.price = price;
    }
}
