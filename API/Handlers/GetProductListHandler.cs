using Domain;
using MediatR;

namespace API;

public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
{
    private readonly IProductRepository _repository;

    public GetProductListHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetProductList());
    }
}
