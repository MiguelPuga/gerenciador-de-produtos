namespace API;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CategoryController
{
    private readonly IMediator _mediator;

    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetCategoryList")]
    [HttpGet]
    public async Task<ActionResult<List<Category>>> GetCategoryList()
    {
        return await _mediator.Send(new GetCategoryListQuery());
    }


    [Route("GetCategoryById")]
    [HttpGet]
    public async Task<ActionResult<Category>> GetCategoryById(Guid id)
    {
        return await _mediator.Send(new GetCategoryByIdQuery(id));
    }


    [Route("CreateCategory")]
    [HttpPost]
    public async Task<CreateCategoryResponse> Post([FromBody] CreateCategoryRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("UpdateCategory")]
    [HttpPost]
    public async Task<UpdateCategoryResponse> Post([FromBody] UpdateCategoryRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("DeleteCategory")]
    [HttpPost]
    public async Task<DeleteCategoryResponse> Post([FromBody] DeleteCategoryRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }
}

