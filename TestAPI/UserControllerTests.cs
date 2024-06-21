using API;
using Domain;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace TestAPI;

public class UserControllerTests
{
    private readonly UserController _controller;
    private readonly Mock<IMediator> _mediator;

    public UserControllerTests()
    {
        _mediator = new Mock<IMediator>();

        _controller = new UserController(_mediator.Object);

    }
}
