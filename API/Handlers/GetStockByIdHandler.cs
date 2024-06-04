using Domain;
using MediatR;

namespace API;

public class GetStockByIdHandler : IRequestHandler<GetStockByIdQuery, Stock>
{

    private readonly IRepository<Stock> _repository;

    public GetStockByIdHandler(IRepository<Stock> repository)
    {
        _repository = repository;
    }

    public Task<Stock> Handle(GetStockByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetById(request.id));
    }
}
