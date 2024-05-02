namespace API;
using Domain;
using MediatR;

public record CreateUserRequest(string name, string email) : IRequest<CreateUserResponse>;