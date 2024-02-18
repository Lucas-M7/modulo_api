// Criar um cliente HTTP
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using var client = new HttpClient();

// Definir a URL da API

var url = "https://api.kanye.rest";

try
{
    // Fazer solicitação GET
    HttpResponseMessage response = await client.GetAsync(url);

    if (response.IsSuccessStatusCode)
    {
        string content = await response.Content.ReadAsStringAsync();

        var conteudoIdentado = JToken.Parse(content).ToString();

        Console.WriteLine(conteudoIdentado);
    }
    else
    {
        Console.WriteLine($"Erro ao processar o conteúdo: {response.StatusCode}");
    }
}
catch
{
    Console.WriteLine($"Erro ao consumir a API");
}