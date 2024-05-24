namespace API;
public record CreateProductResponse(Guid Id, string name, decimal price, string currency, DateTime date);
