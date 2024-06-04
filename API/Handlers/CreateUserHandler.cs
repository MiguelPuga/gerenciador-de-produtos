using MediatR;
using Domain;
namespace API;

public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IRepository<User> _repository;

    public CreateUserHandler(IRepository<User> repository)
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
        var result = new CreateUserResponse(user.Id, user.name, user.email, DateTime.Now);
        return Task.FromResult(result);
    }

}
