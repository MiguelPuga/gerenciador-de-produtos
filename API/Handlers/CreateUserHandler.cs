using MediatR;
using Domain;
namespace API;

public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IUserRepository _repository;

    public CreateUserHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {

        // Cria a entidade
        var user = new User(request.name, request.email);

        // Persiste a entidade no banco
        _repository.Add(user);

        // Retorna a resposta
        var result = new CreateUserResponse
        {
            Id = user.Id,
            name = user.name,
            email = user.email,
            date = DateTime.Now
        };
        return Task.FromResult(result);
    }

}
