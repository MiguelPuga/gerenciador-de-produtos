using Domain;
using MediatR;

namespace API;

public class UpdateStockHandler : IRequestHandler<UpdateStockRequest, UpdateStockResponse>
{
    private readonly IRepository<Stock> _repository;
    private readonly IMediator _mediator;

    public UpdateStockHandler(IMediator mediator, IRepository<Stock> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }
    public async Task<UpdateStockResponse> Handle(UpdateStockRequest request, CancellationToken cancellationToken)
    {
        var stock = await _mediator.Send(new GetStockByIdQuery(request.id));

        _repository.Update(stock, request.stock);

        var result = new UpdateStockResponse(stock.Id, request.stock.product, request.stock.quantity, request.stock.unit, DateTime.Now);

        return await Task.FromResult(result);
    }
}
