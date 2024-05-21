namespace API;
using Domain;
using MediatR;

public record CreateProductRequest(string name, string currency, decimal value) : IRequest<CreateProductResponse>;