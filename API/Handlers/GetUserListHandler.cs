using Domain;
using MediatR;

namespace API;

public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<User>>
{
    private readonly IRepository<User> _repository;

    public GetUserListHandler(IRepository<User> repository)
    {
        _repository = repository;
    }

    public Task<List<User>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetList());
    }
}
