using Domain;
using MediatR;

namespace API;

public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
{
    private readonly IUserRepository _repository;
    private readonly IMediator _mediator;

    public DeleteUserHandler(IMediator mediator, IUserRepository repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
        var user = await _mediator.Send(new GetUserByIdQuery(request.id));
        var result = new DeleteUserResponse
        {
            status = _repository.Delete(user)
        };

        return await Task.FromResult(result);
    }
}
