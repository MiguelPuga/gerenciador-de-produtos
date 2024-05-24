using MediatR;

namespace API;

public record DeleteProductRequest(Guid id) : IRequest<DeleteProductResponse>;