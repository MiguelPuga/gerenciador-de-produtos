using MediatR;
using Domain;
namespace API;

public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
{
    private readonly IProductRepository _repository;

    public CreateProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
    {

        // Cria a entidade
        var product = new Product(request.name, new Price(request.value, request.currency));

        // Persiste a entidade no banco
        _repository.Add(product);

        // Retorna a resposta
        var result = new CreateProductResponse(product.Id, product.name, product.price.currency, product.price.value, DateTime.Now);
        return Task.FromResult(result);
    }
}
