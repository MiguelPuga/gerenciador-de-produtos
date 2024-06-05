using Domain;
namespace API;

public interface ICreateTransactionResponse { }
public record CreateTransactionResponseSuccessful(Guid Id, Guid target, Guid user, Transaction.TransactionType type, DateTime date) : ICreateTransactionResponse;

public record CreateTransactionResponseError(string error) : ICreateTransactionResponse;