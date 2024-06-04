namespace API;

using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Route("GetUserList")]
    [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        return await _mediator.Send(new GetUserListQuery());
    }

    [Route("GetUserById")]
    [HttpGet]
    public async Task<ActionResult<User>> GetUserById(Guid id)
    {
        return await _mediator.Send(new GetUserByIdQuery(id));
    }

    [Route("CreateUser")]
    [HttpPost]
    public async Task<CreateUserResponse> Post([FromBody] CreateUserRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("UpdateUser")]
    [HttpPost]
    public async Task<UpdateUserResponse> Post([FromBody] UpdateUserRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }

    [Route("DeleteUser")]
    [HttpPost]
    public async Task<DeleteUserResponse> Post([FromBody] DeleteUserRequest command)
    {
        var response = await _mediator.Send(command);
        return response;
    }
}

