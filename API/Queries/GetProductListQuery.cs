namespace API;

using Domain;
using MediatR;

public record GetProductListQuery() : IRequest<List<Product>>;