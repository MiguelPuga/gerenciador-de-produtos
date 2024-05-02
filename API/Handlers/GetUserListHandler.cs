using Domain;
using Infrastructure;
using MediatR;

namespace API;

public class GetUserListHandler : IRequestHandler<GetUserListQuery, List<User>>
{
    private readonly IUserRepository _repository;

    public GetUserListHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    public Task<List<User>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetUserList());
    }
}
