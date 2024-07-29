using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

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

    [Fact]
    public void TestaSeUsuarioEhDeletadoComSucesso()
    {
        User user = new("Usuario Teste", "usuario@teste.com");

        _context.Users.Add(user);
        _context.SaveChanges();
        _repository.Delete(user);

        Assert.Null(_context.Users.Find(user.Id));

    }

    [Fact]
    public void TestaSeRetornaFalsoAoDeletarUsuarioInexistente()
    {

        Assert.False(_repository.Delete(null));

    }

    [Fact]
    public void TestaSeUsuarioEhModificadoComSucesso()
    {
        User original = new("Usuario Teste", "usuario@teste.com");
        User modified = new("Usuario Modificado", "usuario@modificado.com");


        _context.Users.Add(original);
        _context.SaveChanges();
        _repository.Update(original, modified);

        Assert.Equal(modified.name, _context.Users.Find(original.Id)?.name);
        Assert.Equal(modified.email, _context.Users.Find(original.Id)?.email);
    }

    [Fact]
    public void TestaSeRetornaNuloAoTentarModificarUsuarioInvalido()
    {
        User modified = new("Usuario Modificado", "usuario@modificado.com");

        Assert.Null(_repository.Update(null, modified));
    }

    [Fact]
    public void TestaSeRetornaNuloAoTentarModificarUsuarioSemEspecificarOsNovosValores()
    {
        User original = new("Usuario Teste", "usuario@teste.com");

        Assert.Null(_repository.Update(original, null));
    }

    [Fact]
    public void TestaSeRetornaListaComSucesso()
    {
        _context.Users.Add(new User("teste1", "teste1@email.com"));
        _context.Users.Add(new User("teste2", "teste2@email.com"));
        _context.Users.Add(new User("teste3", "teste3@email.com"));
        _context.SaveChanges();

        Assert.Equal(_repository.GetList(), _context.Users.ToList());
    }

    [Fact]
    public void TestaSeRetornaPorIdComSucesso()
    {
        User user = new("Usuario Teste", "usuario@teste.com");

        _context.Users.Add(user);
        _context.SaveChanges();

        Assert.Equal(_repository.GetById(user.Id), _context.Users.Find(user.Id));
    }

    [Fact]
    public void TestaSeRetornaNuloAoProcurarPorUsuarioInvalido()
    {
        Assert.Null(_repository.GetById(new Guid()));
    }

}