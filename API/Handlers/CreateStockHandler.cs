using MediatR;
using Domain;
namespace API;

public class CreateStockHandler : IRequestHandler<CreateStockRequest, ICreateStockResponse>
{
    private readonly IRepository<Stock> _repository;
    private readonly IMediator _mediator;

    public CreateStockHandler(IMediator mediator, IRepository<Stock> repository)
    {
        _repository = repository;
        _mediator = mediator;
    }

    public async Task<ICreateStockResponse> Handle(CreateStockRequest request, CancellationToken cancellationToken)
    {

        var product = await _mediator.Send(new GetProductByIdQuery(request.product));

        if (product == null)
        {
            return await Task.FromResult(new CreateStockResponseError("Um produto com este ID não existe."));
        }

        // Cria a entidade
        var stock = new Stock(request.product, request.quantity, request.unit);

        // Persiste a entidade no banco
        _repository.Add(stock);

        // Retorna a resposta
        var result = new CreateStockResponseSuccessful(stock.Id, stock.product, stock.quantity, stock.unit, DateTime.Now);
        return await Task.FromResult(result);
    }

}
