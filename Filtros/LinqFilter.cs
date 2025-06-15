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
    public static void FiltrarArtistaPorGenero(List<Musica> musicas,string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero.Contains(
        genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exindo os Artistas por genero. {genero}");
        foreach (var artista in artistasPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
