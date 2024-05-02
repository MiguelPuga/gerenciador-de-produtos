namespace API;
using MediatR;
using Domain;

public record GetUserByIdQuery(Guid id) : IRequest<User>;