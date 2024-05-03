namespace Infrastructure;
using Domain;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext _context;

    public UserRepository(DatabaseContext context)
    {
        _context = context;
    }

    public User Add(User user)
    {
        var newUser = _context.Users.Add(user).Entity;
        _context.SaveChanges();
        return newUser;
    }

    public bool Delete(User user)
    {
        if (user != null)
        {
            _context.Remove(user);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public User Update(User original, User modified)
    {
        if (original != null && modified != null)
        {
            original.name = modified.name;
            original.email = modified.email;

            _context.SaveChanges();
            return modified;
        }


        return null;
    }

    public List<User> GetUserList()
    {
        return _context.Users.ToList();
    }

    public User GetUserById(Guid id)
    {
        var user = _context.Users.Find(id);

        if (user != null)
        {
            return user;
        }

        return null;
    }
}
