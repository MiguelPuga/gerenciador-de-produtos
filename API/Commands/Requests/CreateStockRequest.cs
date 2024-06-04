namespace API;
using MediatR;

public record CreateStockRequest(Guid product, double quantity, string unit) : IRequest<ICreateStockResponse>;