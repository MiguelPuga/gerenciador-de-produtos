namespace Domain;
public class EntityBase
{
    public Guid Id { get; private set; }

    protected EntityBase()
    {
        Id = Guid.NewGuid();
    }
}

