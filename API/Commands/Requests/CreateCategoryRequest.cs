namespace API;
using Domain;
using MediatR;

public record CreateCategoryRequest(string name) : IRequest<CreateCategoryResponse>;