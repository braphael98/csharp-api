using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_projeto03.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaMusicasFavoritas;

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaMusicasFavoritas = new List<Musica>();
    }
    public void AddMusicasFavoritas(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Musicas Favoritas de {Nome}");
        foreach (var musica in ListaMusicasFavoritas)
        {
            Console.WriteLine($"{musica.Nome} de {musica.Artista}");
        }
    }
}

