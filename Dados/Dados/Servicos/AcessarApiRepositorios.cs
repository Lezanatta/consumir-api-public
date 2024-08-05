using Negocios.Models;
using System.Text.Json;

namespace Dados.Servicos;

public class AcessarApiRepositorios
{
    private readonly string _caminhoApi = "https://api.github.com/";

    public async Task<List<Repositorio>> GetRepositorios(string nomeUsuario)
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(_caminhoApi)
        };

        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("AppName/1.0");

        var response = await httpClient.GetAsync($"users/{nomeUsuario}/repos");

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var repositorios = JsonSerializer.Deserialize<List<Repositorio>>(data, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return repositorios;
        }
        else
        {
            throw new Exception("Erro ao recuperar repositorios da API.");
        }
    }
}
