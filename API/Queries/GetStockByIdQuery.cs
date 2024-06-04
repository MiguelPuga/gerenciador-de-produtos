namespace API;
using MediatR;
using Domain;

public record GetStockByIdQuery(Guid id) : IRequest<Stock>;