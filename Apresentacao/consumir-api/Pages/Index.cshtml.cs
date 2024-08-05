using Microsoft.AspNetCore.Mvc.RazorPages;
using Negocios.Models;
using Servico.Servicos;

namespace consumir_api.Pages;
public class IndexModel : PageModel
{
    private readonly ServiceUsers _serviceUsers;
    private readonly ILogger<IndexModel> _logger;
    public List<Usuario> Usuarios;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        _serviceUsers = new ServiceUsers();
        Usuarios = new List<Usuario>();
    }

    public async Task OnGet(string nomeUsuario)
    {
        try
        {
            if (string.IsNullOrEmpty(nomeUsuario))
                Usuarios = await _serviceUsers.ObterUsuarios();

            else
            {
                var usuarioPesquisado = await _serviceUsers.ObterUsuarioNome(nomeUsuario);
                Usuarios.Clear();
                Usuarios.Add(usuarioPesquisado);
            }
        }
        catch (Exception)
        {
            Usuarios.Clear();
        }
    }

}
