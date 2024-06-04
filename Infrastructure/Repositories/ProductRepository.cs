using Domain;

namespace Infrastructure;

public class ProductRepository : IRepository<Product>
{
    private readonly DatabaseContext _context;

    public ProductRepository(DatabaseContext context)
    {
        _context = context;
    }
    public Product Add(Product product)
    {
        var newProduct = _context.Products.Add(product).Entity;
        _context.SaveChanges();
        return newProduct;
    }

    public bool Delete(Product product)
    {
        if (product != null)
        {
            _context.Remove(product);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public Product GetById(Guid id)
    {
        var product = _context.Products.Find(id);

        if (product != null)
        {
            return product;
        }

        return null;
    }

    public List<Product> GetList()
    {
        return _context.Products.ToList();
    }

    public Product Update(Product original, Product modified)
    {
        if (original != null && modified != null)
        {
            original.name = modified.name;
            original.price = modified.price;
            original.currency = modified.currency;

            _context.SaveChanges();
            return modified;
        }


        return null;
    }
}
