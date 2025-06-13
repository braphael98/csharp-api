using (HttpClient client = new HttpClient())
{
    try//Caminho feliz.
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json"); //puxando os dados
        System.Console.WriteLine(resposta);
    }
    catch (Exception ex)//Deu ruim.
    {
        Console.WriteLine($"PROBLEMA IDENTIFICADO ->> {ex.Message}"); //configurando um possivel erro.
    }


}