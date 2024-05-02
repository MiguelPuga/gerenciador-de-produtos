using MediatR;

namespace API;

public record DeleteUserRequest(Guid id) : IRequest<DeleteUserResponse>;