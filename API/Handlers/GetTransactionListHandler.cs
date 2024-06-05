using Domain;
using MediatR;

namespace API;

public class GetTransactionListHandler : IRequestHandler<GetTransactionListQuery, List<Transaction>>
{
    private readonly IRepository<Transaction> _repository;

    public GetTransactionListHandler(IRepository<Transaction> repository)
    {
        _repository = repository;
    }

    public Task<List<Transaction>> Handle(GetTransactionListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetList());
    }
}
