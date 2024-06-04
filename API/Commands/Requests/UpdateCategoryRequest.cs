using Domain;
using MediatR;

namespace API;

public record UpdateCategoryRequest(Guid id, Category Category) : IRequest<UpdateCategoryResponse>;

