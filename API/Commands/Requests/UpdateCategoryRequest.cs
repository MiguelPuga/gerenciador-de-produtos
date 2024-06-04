using Domain;
using MediatR;

namespace API;

public record UpdateCategoryRequest(Guid id, Category category) : IRequest<UpdateCategoryResponse>;

