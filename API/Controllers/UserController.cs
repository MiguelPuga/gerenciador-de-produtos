namespace API;

using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly IMediator _mediator;
    private readonly UserRepository _repository;

    UserController(IMediator mediator, UserRepository repository)
    {
        _mediator = mediator;
        _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateUserRequest command)
    {
        var response = await _mediator.Send(command);
        return new OkObjectResult(response);
    }
}
