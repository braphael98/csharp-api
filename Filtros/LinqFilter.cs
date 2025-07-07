using System.Linq;
using csharp_projeto03.Modelos;
namespace csharp_projeto03.Filtros;
internal class LinqFilter
{
    public static void FiltrarTodosOsGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(
        generos => generos.Genero).Distinct().ToList();//Pegar todos os generos.
        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(
        genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exindo os Artistas por genero. {genero}");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicasArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(
        nomeArtista)).ToList();
        Console.WriteLine(nomeArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FiltrarMusicasPorAno(List<Musica> musicas,string ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome)
            .Distinct().ToList();
        Console.WriteLine($"Musicas do ano {ano}");
        foreach(var musica in musicasPorAno)
        {
            Console.WriteLine($"-{musica}");
        }
    }
    internal static void FiltrarMusicasPorCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
        Console.WriteLine("Músicas em C#: ");
        foreach(var musica in musicasEmCSharp)
        {
            Console.WriteLine($"-{musica}");
        }

    }


}
