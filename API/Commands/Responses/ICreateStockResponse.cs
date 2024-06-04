namespace API;
public interface ICreateStockResponse { };

public record CreateStockResponseSuccessful(Guid Id, Guid product, double quantity, string unit, DateTime date) : ICreateStockResponse;

public record CreateStockResponseError(string error) : ICreateStockResponse;
