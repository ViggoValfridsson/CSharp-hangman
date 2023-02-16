using hangman.Fetch;
using hangman.GameLogic;

string secretWord = await GetRandomWord.FetchWord();
secretWord = secretWord.ToLower();
var correctLetters = new List<char>();
var incorrectLetters = new List<char>();

while (true)
{
    PrintInfo.ShowLives(incorrectLetters.Count);
    PrintInfo.ShowPartialHidden(secretWord, correctLetters);
    PrintInfo.ShowIncorrectGuesses(incorrectLetters);

    char input = HandleInput.GetInput(correctLetters, incorrectLetters);

    if (HandleInput.IsCorrectGuess(input, secretWord))
    {
        correctLetters.Add(input);
    } 
    else
    {
        incorrectLetters.Add(input);
    }

    if(WinState.HasWon(secretWord, correctLetters))
    {
        PrintInfo.ShowWinMessage(secretWord, correctLetters, incorrectLetters);
        
        break;
    }

    if(incorrectLetters.Count > 6)
    {
        PrintInfo.ShowLossMessage(secretWord);
        break;
    }

    Clear();
}

WriteLine("Press enter to close");
ReadLine();

