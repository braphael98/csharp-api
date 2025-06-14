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
}
