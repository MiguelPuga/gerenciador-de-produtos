namespace API;

using Domain;
using MediatR;

public record GetCategoryListQuery() : IRequest<List<Category>>;