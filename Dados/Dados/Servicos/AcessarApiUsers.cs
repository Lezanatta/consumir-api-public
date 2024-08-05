using Negocios.Models;
using System.Text.Json;

namespace Dados.Servicos;
public class AcessarApiUsers
{
    private readonly string _caminhoApi = "https://api.github.com/";

    public async Task<List<Usuario>> CapturarUsuarios()
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(_caminhoApi)     
        };

        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("AppName/1.0");

        var response = await httpClient.GetAsync("users");

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var usuarios = JsonSerializer.Deserialize<List<Usuario>>(data, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return usuarios.Take(10).ToList();
        }
        else
        {
            throw new Exception("Erro ao recuperar usuarios da API.");
        }
    }

    public async Task<Usuario> CapturarUsuarioNome(string nomeUsuario)
    {
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(_caminhoApi)
        };

        httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("AppName/1.0");

        var response = await httpClient.GetAsync($"users/{nomeUsuario}");

        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadAsStringAsync();

            var usuario = JsonSerializer.Deserialize<Usuario>(data, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return usuario;
        }
        else
        {
            throw new Exception("Erro ao recuperar usuarios da API.");
        }
    }
}
