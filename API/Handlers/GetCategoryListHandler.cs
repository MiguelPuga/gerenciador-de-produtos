using Domain;
using MediatR;

namespace API;

public class GetCategoryListHandler : IRequestHandler<GetCategoryListQuery, List<Category>>
{
    private readonly IRepository<Category> _repository;

    public GetCategoryListHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public Task<List<Category>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repository.GetList());
    }
}
