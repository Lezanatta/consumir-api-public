using Dados.Servicos;
using Negocios.Models;

namespace Servico.Servicos;
public class ServiceUsers
{
    private readonly AcessarApiUsers _acessarApi;
    public ServiceUsers() => _acessarApi = new AcessarApiUsers();
    public async Task<List<Usuario>> ObterUsuarios()
    {
        var usuarios = await _acessarApi.GetUsuarios();

        return usuarios;
    }
    public async Task<Usuario> ObterUsuarioNome(string nomeUsuario)
    {
        var usuario = await _acessarApi.GetUsuarioNome(nomeUsuario);

        return usuario;
    }
}
