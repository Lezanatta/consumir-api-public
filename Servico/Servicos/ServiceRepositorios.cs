using Dados.Servicos;
using Negocios.Models;

namespace Servico.Servicos;
public class ServiceRepositorios
{
    private readonly AcessarApiRepositorios _acessarApi;
    public ServiceRepositorios() => _acessarApi = new AcessarApiRepositorios();

    public async Task<List<Repositorio>> ObterRepositorios(string nomeUsuario)
    {
        var repositorios = await _acessarApi.GetRepositorios(nomeUsuario);

        return repositorios;
    }
}
