using Domain;
using MediatR;

namespace API;

public class GetTransactionByIdHandler : IRequestHandler<GetTransactionByIdQuery, Transaction>
{

    private readonly IRepository<Transaction> _repository;

    public GetTransactionByIdHandler(IRepository<Transaction> repository)
    {
        _repository = repository;
    }

    public Task<Transaction> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetById(request.id));
    }
}
