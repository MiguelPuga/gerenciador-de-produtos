namespace API;

using Domain;
using MediatR;

public record GetTransactionListQuery() : IRequest<List<Transaction>>;

