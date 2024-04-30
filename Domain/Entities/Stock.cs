namespace Domain;

public class Stock
{
    public Quantity quantity { get; private set; }
    public Guid product { get; private set; }

    public Stock (Quantity quantity, Guid product)
    {
        this.quantity = quantity;
        this.product = product;
    }
}
