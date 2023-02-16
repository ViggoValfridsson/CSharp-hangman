namespace hangman.GameLogic;

public class WinState
{
    public static bool HasWon(string secretWord, List<char> correctLetters)
    {
        string guessedWord = PrintInfo.GetGuessedLetters(secretWord, correctLetters);

        if (guessedWord == secretWord) 
        {
            return true;
        }

        return false;
    }
}
