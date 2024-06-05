using Domain;

namespace Infrastructure;

public class StockRepository : IRepository<Stock>
{
    private readonly DatabaseContext _context;

    public StockRepository(DatabaseContext context)
    {
        _context = context;
    }
    public Stock Add(Stock stock)
    {
        var newStock = _context.Stock.Add(stock).Entity;
        _context.SaveChanges();
        return newStock;
    }

    public bool Delete(Stock stock)
    {
        if (stock != null)
        {
            _context.Remove(stock);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public Stock GetById(Guid id)
    {
        var stock = _context.Stock.Find(id);

        if (stock != null)
        {
            return stock;
        }

        return null;
    }

    public List<Stock> GetList()
    {
        return _context.Stock.ToList();
    }

    public Stock Update(Stock original, Stock modified)
    {
        if (original != null && modified != null)
        {
            original.quantity = modified.quantity;
            original.unit = modified.unit;

            _context.SaveChanges();
            return modified;
        }
        return null;
    }
}
