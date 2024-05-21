namespace API;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductController
{
    private readonly IMediator _mediator;
    private readonly IUserRepository _repository;

    public ProductController(IMediator mediator, IUserRepository repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    [Route("GetProductList")]
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProductList()
    {
        return await _mediator.Send(new GetProductListQuery());
    }

    /*
    [Route("GetProductById")]
    [HttpGet]
    public async Task<ActionResult<User>> GetUserById(Guid id)
    {
        return await _mediator.Send(new GetUserByIdQuery(id));
    }
    */

    [Route("CreateProduct")]
    [HttpPost]
    public async Task<CreateProductResponse> Post([FromBody] CreateProductRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    /* [Route("UpdateProduct")]
    [HttpPost]
    public async Task<UpdateUserResponse> Post([FromBody] UpdateUserRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("DeleteProduct")]
    [HttpPost]
    public async Task<DeleteUserResponse> Post([FromBody] DeleteUserRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    } */
}

