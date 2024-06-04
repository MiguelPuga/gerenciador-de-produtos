using Domain;
using MediatR;

namespace API;

public class UpdateProductHandler : IRequestHandler<UpdateProductRequest, UpdateProductResponse>
{
    private readonly IRepository<Product> _repository;
    private readonly IMediator _mediator;

    public UpdateProductHandler(IMediator mediator, IRepository<Product> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }
    public async Task<UpdateProductResponse> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _mediator.Send(new GetProductByIdQuery(request.id));

        _repository.Update(product, request.product);

        var result = new UpdateProductResponse(product.Id, request.product.name, request.product.price, request.product.currency, DateTime.Now);

        return await Task.FromResult(result);
    }
}
