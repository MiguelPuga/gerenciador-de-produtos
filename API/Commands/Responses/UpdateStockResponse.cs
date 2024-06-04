namespace API;

public record UpdateStockResponse(Guid Id, Guid product, double quantity, string unit, DateTime date);

