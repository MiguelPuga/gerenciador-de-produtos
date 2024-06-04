using Domain;
using MediatR;

namespace API;

public class GetStockListHandler : IRequestHandler<GetStockListQuery, List<Stock>>
{
    private readonly IRepository<Stock> _repository;

    public GetStockListHandler(IRepository<Stock> repository)
    {
        _repository = repository;
    }

    public Task<List<Stock>> Handle(GetStockListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetList());
    }
}
