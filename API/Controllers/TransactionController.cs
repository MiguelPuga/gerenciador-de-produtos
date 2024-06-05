namespace API;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TransactionController
{
    private readonly IMediator _mediator;

    public TransactionController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetTransactionList")]
    [HttpGet]
    public async Task<ActionResult<List<Transaction>>> GetTransactions()
    {
        return await _mediator.Send(new GetTransactionListQuery());
    }

    [Route("GetTransactionById")]
    [HttpGet]
    public async Task<ActionResult<Transaction>> GetTransactionById(Guid id)
    {
        return await _mediator.Send(new GetTransactionByIdQuery(id));
    }

    [Route("CreateTransaction")]
    [HttpPost]
    public async Task<ICreateTransactionResponse> Post([FromBody] CreateTransactionRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

}

