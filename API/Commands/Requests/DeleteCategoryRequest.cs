using MediatR;

namespace API;

public record DeleteCategoryRequest(Guid id) : IRequest<DeleteCategoryResponse>;