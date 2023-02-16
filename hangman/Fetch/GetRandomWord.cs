using Microsoft.Extensions.Configuration;
namespace hangman.Fetch;

public class GetRandomWord
{
    public static void FetchWord()
    {
        //var builder = WebApplication.CreateBuilder();
        //var movieApiKey = builder.Configuration["APINinjas:ApiKey"];

        //var app = builder.Build();

        //app.MapGet("/", () => movieApiKey);

        //app.Run();

        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();
        string apiKey = config["APINinjas:ApiKey"];
        Console.WriteLine(apiKey + "api");

    }
}
