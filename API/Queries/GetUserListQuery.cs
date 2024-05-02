namespace API;

using Domain;
using MediatR;

public record GetUserListQuery() : IRequest<List<User>>;

