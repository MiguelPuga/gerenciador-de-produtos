using Domain;
using MediatR;

namespace API;

public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
{
    private readonly IUserRepository _repository;
    private readonly IMediator _mediator;

    public UpdateUserHandler(IMediator mediator, IUserRepository repository)
    {
        _mediator = mediator;
        _repository = repository;
    }
    public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var user = await _mediator.Send(new GetUserByIdQuery(request.id));

        _repository.Update(user, request.user);

        var result = new UpdateUserResponse(user.Id, request.user.name, request.user.email, DateTime.Now);

        return await Task.FromResult(result);
    }
}
