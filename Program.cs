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
       
        LinqFilter.FiltrarMusicasPorCSharp(musicas);
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGeneros(musicas); //filtro objeto
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2009");

        //var musicasPrefeidasBruno = new MusicasPreferidas("Bruno");
        //musicasPrefeidasBruno.AddMusicasFavoritas(musicas[1]);
        //musicasPrefeidasBruno.AddMusicasFavoritas(musicas[300]);
        //musicasPrefeidasBruno.AddMusicasFavoritas(musicas[43]);
        //musicasPrefeidasBruno.AddMusicasFavoritas(musicas[199]);

        //musicasPrefeidasBruno.ExibirMusicasFavoritas();
        //musicasPrefeidasBruno.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"PROBLEMA IDENTIFICADO ->> {ex.Message}"); //configurando um possivel erro.
    }


}