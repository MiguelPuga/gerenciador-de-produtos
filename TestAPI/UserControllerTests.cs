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

    [Fact]
    public async void TestAPICreateUser()
    {
        string name = "Usuario teste";
        string email = "usuario@teste.com";

        var request = new CreateUserRequest(name, email);
        var response = new CreateUserResponse(new Guid(), name, email, DateTime.Now);

        _mediator.Setup(x => x.Send(request,
            It.IsAny<CancellationToken>())).ReturnsAsync(response);

        var result = await _controller.Post(request);

        Assert.Equal(result, response);

    }
}
