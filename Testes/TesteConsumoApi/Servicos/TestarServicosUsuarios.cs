using Servico.Servicos;

namespace TesteConsumoApi.Servicos;
public class TestarServicosUsuarios
{
    private readonly ServiceUsers _service;
    public TestarServicosUsuarios() => _service = new ServiceUsers();

    [Fact]
    public void TestarCapturaUsuarios()
    {
        var usuarios = _service.ObterUsuarios();

        Assert.NotNull(usuarios);
    }

    [Fact]
    public void TestarCapturaUsuarioPorNome()
    {
        var nomeUsuario = "Lezanatta";

        var usuarios = _service.ObterUsuarioNome(nomeUsuario);

        Assert.NotNull(usuarios);
    }

    [Fact]
    public async Task TestarCapturaExcecaoUsuarioPorNome()
    {
        var nomeUsuario = "LezanattaError";

        var usuarios = _service.ObterUsuarioNome(nomeUsuario);

        await Assert.ThrowsAsync<Exception>(async () => await _service.ObterUsuarioNome(nomeUsuario));
    }
}
