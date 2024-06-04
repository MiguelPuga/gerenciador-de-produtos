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
        var Category = await _mediator.Send(new GetCategoryByIdQuery(request.id));

        _repository.Update(Category, request.Category);

        var result = new UpdateCategoryResponse(Category.Id, request.Category.name, DateTime.Now);

        return await Task.FromResult(result);
    }
}
