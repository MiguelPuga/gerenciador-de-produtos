using Domain;
using MediatR;

namespace API;

public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryRequest, DeleteCategoryResponse>
{
    private readonly IRepository<Category> _repository;
    private readonly IMediator _mediator;

    public DeleteCategoryHandler(IMediator mediator, IRepository<Category> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    public async Task<DeleteCategoryResponse> Handle(DeleteCategoryRequest request, CancellationToken cancellationToken)
    {
        var Category = await _mediator.Send(new GetCategoryByIdQuery(request.id));

        string response = "Não foi possível deletar a Categoria";

        if (_repository.Delete(Category))
        {
            response = "Categoria deletada com sucesso";
        }

        var result = new DeleteCategoryResponse(response);

        return await Task.FromResult(result);
    }
}
