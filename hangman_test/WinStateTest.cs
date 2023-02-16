using hangman.GameLogic;
using Xunit.Abstractions;

namespace hangman_test;

public class WinStateTest
{
    [Fact]
    public void CorrectLetters()
    {
        var word = "hello";
        var guessedLetter = new List<char>() { 'h', 'e', 'l', 'o' };
        var result = WinState.HasWon(word, guessedLetter);

        Assert.True(result);
    }
    [Fact]
    public void IncompleteLetters()
    {
        var word = "hello";
        var guessedLetter = new List<char>() { 'h', 'e', 'l' };
        var result = WinState.HasWon(word, guessedLetter);

        Assert.False(result);
    }
}
