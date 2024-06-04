using Domain;
using MediatR;

namespace API;

public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, Category>
{

    private readonly IRepository<Category> _repository;

    public GetCategoryByIdHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetById(request.id));
    }
}
