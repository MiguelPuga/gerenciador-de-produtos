using API;
using Domain;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace TestAPI;

public class UserRepositoryTests
{
    private readonly DatabaseContext _context;

    private readonly UserRepository _repository;

    public UserRepositoryTests()
    {

        var dbOptions = new DbContextOptionsBuilder<DatabaseContext>()
    .UseInMemoryDatabase(databaseName: Guid.NewGuid()
    .ToString());

        _context = new DatabaseContext(dbOptions.Options);

        _repository = new UserRepository(_context);

    }

    [Fact]
    public void TestaSeUsuarioEhCriadoComSucesso()
    {
        User user = new("Usuario Teste", "usuario@teste.com");

        _repository.Add(user);

        Assert.Equal(user, _context.Users.Find(user.Id));

    }
}