using MediatR;
using Domain;
namespace API;

public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
{
    private readonly IRepository<Product> _repository;

    public CreateProductHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
    {

        // Cria a entidade
        var product = new Product(request.name, request.price, request.currency);

        // Persiste a entidade no banco
        _repository.Add(product);

        // Retorna a resposta
        var result = new CreateProductResponse(product.Id, product.name, product.price, product.currency, DateTime.Now);
        return Task.FromResult(result);
    }
}
