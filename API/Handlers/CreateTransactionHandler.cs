using MediatR;
using Domain;
namespace API;

public class CreateTransactionHandler : IRequestHandler<CreateTransactionRequest, ICreateTransactionResponse>
{
    private readonly IRepository<Transaction> _repository;
    private readonly IMediator _mediator;

    public CreateTransactionHandler(IMediator mediator, IRepository<Transaction> repository)
    {
        _repository = repository;
        _mediator = mediator;
    }

    public async Task<ICreateTransactionResponse> Handle(CreateTransactionRequest request, CancellationToken cancellationToken)
    {

        var user = await _mediator.Send(new GetUserByIdQuery(request.user));

        if (user == null)
        {
            return await Task.FromResult(new CreateTransactionResponseError("Um usuário com este ID não existe."));
        }

        var product = await _mediator.Send(new GetProductByIdQuery(request.target));
        var stock = await _mediator.Send(new GetStockByIdQuery(request.target));

        if (product == null && stock == null)
        {
            return await Task.FromResult(new CreateTransactionResponseError("Um produto ou estoque com este ID não existe."));
        }

        // Cria a entidade
        var transaction = new Transaction(request.target, request.user, request.type);

        // Persiste a entidade no banco
        _repository.Add(transaction);

        // Retorna a resposta
        var result = new CreateTransactionResponseSuccessful(transaction.Id, transaction.target, transaction.user, transaction.type, DateTime.Now);
        return await Task.FromResult(result);
    }

}
