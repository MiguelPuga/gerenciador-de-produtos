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

    public Guid target { get; set; }
    public Guid user { get; set; }
    public TransactionType type { get; set; }

    public Transaction(Guid target, Guid user, TransactionType type)
    {
        this.target = target;
        this.user = user;
        this.type = type;
    }
}
