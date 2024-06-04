namespace API;

using Domain;
using MediatR;

public record GetStockListQuery() : IRequest<List<Stock>>;

