using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class CepService
{
    private readonly HttpClient _http = new HttpClient();

    public async Task<string> BuscarEndereco(string cep)
    {
        var url = $"https://viacep.com.br/ws/{cep}/json/";

        var response = await _http.GetStringAsync(url);

        var json = JsonDocument.Parse(response);

        var cidade = json.RootElement.GetProperty("localidade").GetString();

        return cidade ?? "Cidade não encontrada";
    }
}