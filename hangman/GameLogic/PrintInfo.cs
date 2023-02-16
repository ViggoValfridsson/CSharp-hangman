namespace hangman.GameLogic;

public class PrintInfo
{
    public static void ShowPartialHidden(string secretWord, List<char> guessedLetters)
    {
        WriteLine(GetGuessedLetters(secretWord, guessedLetters));
    }

    public static string GetGuessedLetters(string secretWord, List<char> guessedLetters)
    {
        string printString = "";

        for (int i = 0; i < secretWord.Length; i++)
        {
            if (guessedLetters.Contains(secretWord[i]))
            {
                printString += secretWord[i];
            }
            else
            {
                printString += "_";
            }
        }

        return (printString);
    }

    public static void ShowIncorrectGuesses(List<char> incorrectGuesses)
    {
        string guessedLetters = "";

        for (int i = 0; i < incorrectGuesses.Count; i++)
        {
            if (i == incorrectGuesses.Count - 1)
            {
                guessedLetters += $"{incorrectGuesses[i]}";
            }
            else
            {
                guessedLetters += $"{incorrectGuesses[i]}, ";
            }
        }

        WriteLine($"Incorrect letters: {guessedLetters}");
    }

    public static void ShowLives(int guesses)
    {
        switch(guesses)
        {
            case 0:
                WriteLine("\n\n\n\n\n=========");
                break;
            case 1:
                WriteLine("\r\n  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n=========");
                break;
            case 2:
                WriteLine("\r\n  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n=========");
                break;
            case 3:
                WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
                break;
            case 4:
                WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
                break;
            case 5:
                WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
                break;
            case 6:
                WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |\r\n=========");
                break;
        }
        WriteLine();
    }

    public static void ShowWinMessage(string secretWord, List<char> correctLetters, List<char> incorrectLetters)
    {
        Clear();
        WriteLine("\r\n\r\n____    ____  ______    __    __     ____    __    ____  __  .__   __.  __  \r\n\\   \\  /   / /  __  \\  |  |  |  |    \\   \\  /  \\  /   / |  | |  \\ |  | |  | \r\n \\   \\/   / |  |  |  | |  |  |  |     \\   \\/    \\/   /  |  | |   \\|  | |  | \r\n  \\_    _/  |  |  |  | |  |  |  |      \\            /   |  | |  . `  | |  | \r\n    |  |    |  `--'  | |  `--'  |       \\    /\\    /    |  | |  |\\   | |__| \r\n    |__|     \\______/   \\______/         \\__/  \\__/     |__| |__| \\__| (__) \r\n                                                                            \r\n\r\n");
        WriteLine($"Good job! You guessed the word \"{secretWord}\" in {correctLetters.Count + incorrectLetters.Count} guesses");
    }

    public static void ShowLossMessage(string secretWord)
    {
        Clear();
        WriteLine("  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
        WriteLine("\r\n\r\n  _______      ___      .___  ___.  _______      ______   ____    ____  _______ .______       __  \r\n /  _____|    /   \\     |   \\/   | |   ____|    /  __  \\  \\   \\  /   / |   ____||   _  \\     |  | \r\n|  |  __     /  ^  \\    |  \\  /  | |  |__      |  |  |  |  \\   \\/   /  |  |__   |  |_)  |    |  | \r\n|  | |_ |   /  /_\\  \\   |  |\\/|  | |   __|     |  |  |  |   \\      /   |   __|  |      /     |  | \r\n|  |__| |  /  _____  \\  |  |  |  | |  |____    |  `--'  |    \\    /    |  |____ |  |\\  \\----.|__| \r\n \\______| /__/     \\__\\ |__|  |__| |_______|    \\______/      \\__/     |_______|| _| `._____|(__) \r\n                                                                                                  \r\n\r\n");
        WriteLine($"\n The correct word was {secretWord}");
    }
}
