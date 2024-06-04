using Domain;
using MediatR;

namespace API;

public class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
{
    private readonly IRepository<User> _repository;
    private readonly IMediator _mediator;

    public DeleteUserHandler(IMediator mediator, IRepository<User> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
        var user = await _mediator.Send(new GetUserByIdQuery(request.id));

        string response = "Não foi possível deletar o usuário";

        if (_repository.Delete(user))
        {
            response = "Usuário deletado com sucesso";
        }

        var result = new DeleteUserResponse(response);

        return await Task.FromResult(result);
    }
}
