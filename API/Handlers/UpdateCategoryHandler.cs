using Domain;
using MediatR;

namespace API;

public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryRequest, UpdateCategoryResponse>
{
    private readonly IRepository<Category> _repository;
    private readonly IMediator _mediator;

    public UpdateCategoryHandler(IMediator mediator, IRepository<Category> repository)
    {
        _mediator = mediator;
        _repository = repository;
    }
    public async Task<UpdateCategoryResponse> Handle(UpdateCategoryRequest request, CancellationToken cancellationToken)
    {
        var category = await _mediator.Send(new GetCategoryByIdQuery(request.id));

        _repository.Update(category, request.category);

        var result = new UpdateCategoryResponse(category.Id, request.category.name, DateTime.Now);

        return await Task.FromResult(result);
    }
}
