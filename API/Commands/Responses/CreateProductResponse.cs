namespace API;
public record CreateProductResponse(Guid Id, string name, string currency, decimal value, DateTime date);
