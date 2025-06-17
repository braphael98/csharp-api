using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace csharp_projeto03.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; } //nome da pessoa
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
            Console.WriteLine();
        }
    }
    public void GerarArquivoJson()// cria um arquivo com objeto anonimo.
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicasFavoritas
        });
        string nomeDoArquivo = $"Musicas-Favoritas-{Nome}.json";
        
        File.WriteAllText(nomeDoArquivo, json);//Gerador do arquivo
        Console.WriteLine("Arquivo JSON criado com sucesso !");
    }
}

