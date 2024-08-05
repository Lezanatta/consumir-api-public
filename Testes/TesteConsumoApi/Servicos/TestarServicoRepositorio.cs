using Servico.Servicos;

namespace TesteConsumoApi.Servicos;
public class TestarServicoRepositorio
{
    private readonly ServiceRepositorios _serviceRepositorio;

    public TestarServicoRepositorio() => _serviceRepositorio = new ServiceRepositorios();

    [Fact]
    public void TestarCapturaRepositorios()
    {
        var nomeRepositorio = "LeZanatta";

        var repositorios = _serviceRepositorio.ObterRepositorios(nomeRepositorio);

        Assert.NotNull(repositorios);
    }

    [Fact]
    public async Task TestarExcecaoCapturaRepositorio()
    {
        var nomeRepositorio = "LeZanattaErro";

        await Assert.ThrowsAsync<Exception>(async () => await _serviceRepositorio.ObterRepositorios(nomeRepositorio));
    }
}