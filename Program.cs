using System.Text.Json;
using csharp_projeto03.Modelos;
using csharp_projeto03.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync(
       "https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); //puxando os dados
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; //padrao para receber os dados como um objeto.
        //LinqFilter.FiltrarTodosOsGeneros(musicas); //filtro objeto
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas, "rock");
        LinqFilter.FiltrarMusicasArtista(musicas, "Michel Teló");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"PROBLEMA IDENTIFICADO ->> {ex.Message}"); //configurando um possivel erro.
    }


}