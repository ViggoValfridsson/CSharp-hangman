using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using hangman.Models;

namespace hangman.Fetch;

public class GetRandomWord
{
    public static async Task<string> FetchWord()
    {
        var config = new ConfigurationBuilder()
            .AddUserSecrets<GetRandomWord>()
            .Build();
        string apiKey = config["APINinjas:ApiKey"];

        HttpClient client = new();

        try
        {
            var fetchRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.api-ninjas.com/v1/randomword"),
                Headers =
                {
                    { "X-Api-Key", apiKey }
                }
            };
            var response = client.SendAsync(fetchRequest).Result;
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            RandomWordModel randomWord = JsonConvert.DeserializeObject<RandomWordModel>(responseBody)!;

            return randomWord.word!;
        }
        catch
        {
            throw new HttpRequestException("Could not get random word, please restart application");
        }
    }
}
