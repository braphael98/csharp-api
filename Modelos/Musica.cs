
using System.Text.Json.Serialization;

namespace csharp_projeto03.Modelos;

internal class Musica //As vezes é bom traduzir o nome dos dados.
{
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
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica : {Nome}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Duração (segundos): {Duracao}");
    }
}
