using Domain;
using MediatR;

namespace API;

public record UpdateUserRequest(Guid id, User user) : IRequest<UpdateUserResponse>;

