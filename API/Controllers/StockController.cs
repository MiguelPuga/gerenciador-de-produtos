namespace API;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StockController
{
    private readonly IMediator _mediator;

    public StockController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetStockList")]
    [HttpGet]
    public async Task<ActionResult<List<Stock>>> GetStocks()
    {
        return await _mediator.Send(new GetStockListQuery());
    }

    [Route("GetStockById")]
    [HttpGet]
    public async Task<ActionResult<Stock>> GetStockById(Guid id)
    {
        return await _mediator.Send(new GetStockByIdQuery(id));
    }

    [Route("CreateStock")]
    [HttpPost]
    public async Task<ICreateStockResponse> Post([FromBody] CreateStockRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("UpdateStock")]
    [HttpPost]
    public async Task<UpdateStockResponse> Post([FromBody] UpdateStockRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("DeleteStock")]
    [HttpPost]
    public async Task<DeleteStockResponse> Post([FromBody] DeleteStockRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }
}

