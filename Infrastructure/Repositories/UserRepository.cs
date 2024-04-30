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
        return _context.Users.Add(user).Entity;
    }

    public bool Delete(User user)
    {
        throw new NotImplementedException();
    }

    public User Update(User user)
    {
        throw new NotImplementedException();
    }

}
