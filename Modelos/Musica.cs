
using System.Text.Json.Serialization;

namespace csharp_projeto03.Modelos;

internal class Musica //As vezes é bom traduzir o nome dos dados.
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]// Prorpriadade json
    public string? Nome { get; set; }//Propriedade da classe traduzida do JSON
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string Ano {  get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade {
        get
        {
            return tonalidades[Key];
        }
            }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica : {Nome}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Duração (segundos): {Duracao}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
