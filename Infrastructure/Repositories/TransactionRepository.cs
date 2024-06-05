namespace Infrastructure;
using Domain;

public class TransactionRepository : IRepository<Transaction>
{
    private readonly DatabaseContext _context;

    public TransactionRepository(DatabaseContext context)
    {
        _context = context;
    }

    public Transaction Add(Transaction transaction)
    {
        var newTransaction = _context.Transactions.Add(transaction).Entity;
        _context.SaveChanges();
        return newTransaction;
    }

    public bool Delete(Transaction transaction)
    {
        throw new NotSupportedException();
    }

    public Transaction Update(Transaction original, Transaction modified)
    {
        throw new NotSupportedException();
    }

    public List<Transaction> GetList()
    {
        return _context.Transactions.ToList();
    }

    public Transaction GetById(Guid id)
    {
        var transaction = _context.Transactions.Find(id);

        if (transaction != null)
        {
            return transaction;
        }

        return null;
    }
}
