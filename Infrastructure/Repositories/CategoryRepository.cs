using Domain;

namespace Infrastructure;

public class CategoryRepository : IRepository<Category>
{
    private readonly DatabaseContext _context;

    public CategoryRepository(DatabaseContext context)
    {
        _context = context;
    }
    public Category Add(Category category)
    {
        var newCategory = _context.Categories.Add(category).Entity;
        _context.SaveChanges();
        return newCategory;
    }

    public bool Delete(Category category)
    {
        if (category != null)
        {
            _context.Remove(category);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public Category GetById(Guid id)
    {
        var category = _context.Categories.Find(id);

        if (category != null)
        {
            return category;
        }

        return null;
    }

    public List<Category> GetList()
    {
        return _context.Categories.ToList();
    }

    public Category Update(Category original, Category modified)
    {
        if (original != null && modified != null)
        {
            original.name = modified.name;

            _context.SaveChanges();
            return modified;
        }


        return null;
    }
}
