using System.Text.Json;
using csharp_projeto03.Modelos; 

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); //puxando os dados
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta); //padrao para receber os dados como um objeto.
        musicas[0].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"PROBLEMA IDENTIFICADO ->> {ex.Message}"); //configurando um possivel erro.
    }


}