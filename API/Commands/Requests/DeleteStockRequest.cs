using MediatR;

namespace API;

public record DeleteStockRequest(Guid id) : IRequest<DeleteStockResponse>;