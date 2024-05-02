using Domain;
using MediatR;

namespace API;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
{

    private readonly IUserRepository _repository;

    public GetUserByIdHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetUserById(request.id));
    }
}
