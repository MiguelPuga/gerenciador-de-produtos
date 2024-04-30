namespace Domain;

public class User : EntityBase
{
    public string name { get; private set; }
    public string email { get; private set; }

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
}
