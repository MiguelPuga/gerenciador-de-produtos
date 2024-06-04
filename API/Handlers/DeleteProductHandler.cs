using Domain;
using MediatR;

namespace API;

public class DeleteProductHandler : IRequestHandler<DeleteProductRequest, DeleteProductResponse>
{
    private readonly IRepository<Product> _repository;
    private readonly IMediator _mediator;

    public DeleteProductHandler(IMediator mediator, IRepository<Product> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    public async Task<DeleteProductResponse> Handle(DeleteProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(request.id));

        string response = "Não foi possível deletar o produto";

        if (_repository.Delete(product))
        {
            response = "Produto deletado com sucesso";
        }

        var result = new DeleteProductResponse(response);

        return await Task.FromResult(result);
    }
}
