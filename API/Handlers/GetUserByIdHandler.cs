using Domain;
using MediatR;

namespace API;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, User>
{

    private readonly IRepository<User> _repository;

    public GetUserByIdHandler(IRepository<User> repository)
    {
        _repository = repository;
    }

    public Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetById(request.id));
    }
}
