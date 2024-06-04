using Domain;
using MediatR;

namespace API;

public class DeleteStockHandler : IRequestHandler<DeleteStockRequest, DeleteStockResponse>
{
    private readonly IRepository<Stock> _repository;
    private readonly IMediator _mediator;

    public DeleteStockHandler(IMediator mediator, IRepository<Stock> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    public async Task<DeleteStockResponse> Handle(DeleteStockRequest request, CancellationToken cancellationToken)
    {
        var Stock = await _mediator.Send(new GetStockByIdQuery(request.id));

        string response = "Não foi possível deletar o estoque";

        if (_repository.Delete(Stock))
        {
            response = "Estoque deletado com sucesso";
        }

        var result = new DeleteStockResponse(response);

        return await Task.FromResult(result);
    }
}
