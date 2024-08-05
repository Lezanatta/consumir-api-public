using Microsoft.AspNetCore.Mvc.RazorPages;
using Negocios.Models;
using Servico.Servicos;

namespace consumir_api.Pages;
public class RepositoriosModel : PageModel
{
    private readonly ILogger<RepositoriosModel> _logger;
    private readonly ServiceRepositorios _serviceRepositorios;
    public List<Repositorio> Repositorios { get; private set; }

    public RepositoriosModel(ILogger<RepositoriosModel> logger)
    {
        _logger = logger;
        _serviceRepositorios = new ServiceRepositorios();
    }

    public async Task OnGet(string username)
    {
        try
        {
            if (!string.IsNullOrEmpty(username))
            {
                Repositorios = await _serviceRepositorios.ObterRepositorios(username);
            }
            else
            {
                Repositorios = new List<Repositorio>();
            }
        }
        catch (Exception)
        {
            Repositorios = new List<Repositorio>();
        }
    }
}
