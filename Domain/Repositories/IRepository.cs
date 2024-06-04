namespace Domain;

public interface IRepository<T>
{
    public T Add(T product);
    public T Update(T original, T modified);

    public bool Delete(T product);

    public List<T> GetList();

    public T GetById(Guid id);
}
