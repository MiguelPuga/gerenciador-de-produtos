namespace API;
using MediatR;
using Domain;

public record GetCategoryByIdQuery(Guid id) : IRequest<Category>;