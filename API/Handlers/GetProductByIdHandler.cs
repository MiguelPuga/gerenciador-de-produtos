using Domain;
using MediatR;

namespace API;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
{

    private readonly IRepository<Product> _repository;

    public GetProductByIdHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetById(request.id));
    }
}
