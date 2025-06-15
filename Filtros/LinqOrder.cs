using csharp_projeto03.Modelos;
using System.Linq;
namespace csharp_projeto03.Filtros;
internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica =>musica.Artista).Select
        (musica => musica.Artista).Distinct().ToList();//Puxa a chave Artista e ordena.
        
        Console.WriteLine("Lista de Artistas:");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}
