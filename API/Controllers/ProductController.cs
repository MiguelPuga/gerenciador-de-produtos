namespace API;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductController
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetProductList")]
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProductList()
    {
        return await _mediator.Send(new GetProductListQuery());
    }


    [Route("GetProductById")]
    [HttpGet]
    public async Task<ActionResult<Product>> GetProductById(Guid id)
    {
        return await _mediator.Send(new GetProductByIdQuery(id));
    }


    [Route("CreateProduct")]
    [HttpPost]
    public async Task<CreateProductResponse> Post([FromBody] CreateProductRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("UpdateProduct")]
    [HttpPost]
    public async Task<UpdateProductResponse> Post([FromBody] UpdateProductRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("DeleteProduct")]
    [HttpPost]
    public async Task<DeleteProductResponse> Post([FromBody] DeleteProductRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }
}

