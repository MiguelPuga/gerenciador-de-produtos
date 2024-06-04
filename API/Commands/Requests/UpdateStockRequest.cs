using Domain;
using MediatR;

namespace API;

public record UpdateStockRequest(Guid id, Stock stock) : IRequest<UpdateStockResponse>;

