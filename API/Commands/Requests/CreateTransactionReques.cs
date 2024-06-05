namespace API;

using System.Diagnostics;
using Domain;
using MediatR;

public record CreateTransactionRequest(Guid target, Guid user, Transaction.TransactionType type) : IRequest<ICreateTransactionResponse>;