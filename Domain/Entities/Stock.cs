namespace Domain;

public class Stock : EntityBase
{
    public Guid product { get; set; }
    public double quantity { get; set; }
    public string unit { get; set; }

    public Stock(Guid product, double quantity, string unit)
    {
        this.quantity = quantity;
        this.product = product;
        this.unit = unit;
    }
}
