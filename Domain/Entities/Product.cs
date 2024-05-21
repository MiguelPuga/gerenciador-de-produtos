namespace Domain;

public class Product : EntityBase
{
    public string name { get; set; }
    public Price price { get; set; }

    private Product() { }
    public Product(string name, Price price)
    {
        this.name = name;
        this.price = price;
    }
}
