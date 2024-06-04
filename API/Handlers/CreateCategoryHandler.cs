using MediatR;
using Domain;
namespace API;

public class CreateCategoryHandler : IRequestHandler<CreateCategoryRequest, CreateCategoryResponse>
{
    private readonly IRepository<Category> _repository;

    public CreateCategoryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public Task<CreateCategoryResponse> Handle(CreateCategoryRequest request, CancellationToken cancellationToken)
    {

        // Cria a entidade
        var category = new Category(request.name);

        // Persiste a entidade no banco
        _repository.Add(category);

        // Retorna a resposta
        var result = new CreateCategoryResponse(category.Id, category.name, DateTime.Now);
        return Task.FromResult(result);
    }
}
