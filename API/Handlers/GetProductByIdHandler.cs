using Domain;
using MediatR;

namespace API;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{

    private readonly IProductRepository _repository;

    public GetProductByIdHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetProductById(request.id));
    }
}
