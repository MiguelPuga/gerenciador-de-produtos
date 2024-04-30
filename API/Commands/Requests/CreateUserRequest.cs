namespace API;
using Domain;
using MediatR;

public class CreateUserRequest : IRequest<CreateUserResponse>
{
    public string name { get; set; }
    public string email { get; set; }
}
