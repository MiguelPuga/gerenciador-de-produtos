namespace Domain;

public interface IProductRepository
{
    public Product Add(Product product);
    public Product Update(Product original, Product modified);

    public bool Delete(Product product);

    public List<Product> GetProductList();

    public Product GetProductById(Guid id);
}
