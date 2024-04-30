namespace Domain;

public interface IUserRepository
{
    public User Add(User user);
    public User Update(User user);

    public bool Delete(User user);
}
