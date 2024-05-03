namespace Domain;

public class Product : EntityBase
{
    public string name { get; set; }
    public Price price { get; set; }

    public Product(string name, Price price)
    {
        this.name = name;
        this.price = price;
    }
}
