using System.Dynamic;

namespace Domain;

public class Product : EntityBase
{
    public string name { get; set; }
    public decimal price { get; set; }

    public string currency { get; set; }

    public Product(string name, decimal price, string currency)
    {
        this.name = name;
        this.price = price;
        this.currency = currency;
    }
}
