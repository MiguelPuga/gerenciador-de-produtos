namespace Domain;

public class Transaction : EntityBase
{
    public enum TransactionType
    {
        Search = 's',
        Add = 'a',
        Delete = 'd',
        Update = 'u'
    }

    public Guid product { get; set; }
    public Guid user { get; set; }
    public Guid stock { get; set; }
    public double quantity { get; set; }
    public TransactionType type { get; set; }

    public Transaction(Guid product, Guid user, Guid stock, double quantity, TransactionType type)
    {
        this.product = product;
        this.user = user;
        this.stock = stock;
        this.quantity = quantity;
        this.type = type;
    }
}
