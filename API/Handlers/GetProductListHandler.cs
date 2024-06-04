using Domain;
using MediatR;

namespace API;

public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
{
    private readonly IRepository<Product> _repository;

    public GetProductListHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetList());
    }
}
