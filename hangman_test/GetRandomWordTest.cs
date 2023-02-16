using hangman.Fetch;
namespace hangman_test;

public class GetRandomWordTest
{
    [Fact]
    public async void GetRandomWordReturnsString()
    {
        string result = await GetRandomWord.FetchWord();
        bool isNotNullOrWhitespace = String.IsNullOrWhiteSpace(result);

        Assert.False(isNotNullOrWhitespace);
    }
}