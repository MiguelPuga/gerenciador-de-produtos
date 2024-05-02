namespace Domain;

public class User : EntityBase
{
    public string name { get; set; }
    public string email { get; set; }

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }
}
