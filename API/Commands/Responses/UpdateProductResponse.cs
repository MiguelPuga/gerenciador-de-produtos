namespace API;

public record UpdateProductResponse(Guid Id, string name, decimal price, string currency, DateTime date);

