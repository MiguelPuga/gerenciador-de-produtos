namespace API;
using MediatR;
using Domain;

public record GetProductByIdQuery(Guid id) : IRequest<Product>;