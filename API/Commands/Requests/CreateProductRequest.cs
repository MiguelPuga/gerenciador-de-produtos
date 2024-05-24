namespace API;
using Domain;
using MediatR;

public record CreateProductRequest(string name, decimal price, string currency) : IRequest<CreateProductResponse>;