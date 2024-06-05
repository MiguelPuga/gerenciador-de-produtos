namespace API;
using MediatR;
using Domain;

public record GetTransactionByIdQuery(Guid id) : IRequest<Transaction>;