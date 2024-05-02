namespace Domain;

public interface IUserRepository
{
    public User Add(User user);
    public User Update(User original, User modified);

    public bool Delete(User user);

    public List<User> GetUserList();

    public User GetUserById(Guid id);
}
