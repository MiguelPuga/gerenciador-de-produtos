using Domain;
using MediatR;

namespace API;

public record UpdateProductRequest(Guid id, Product product) : IRequest<UpdateProductResponse>;

