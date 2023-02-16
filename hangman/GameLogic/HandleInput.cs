namespace hangman.GameLogic;

public class HandleInput
{
    public static char GetInput(List<char> correctLetters, List<char> incorrectLetters)
    {
        while (true)
        {
            Write("Enter your guess: ");
            string result = ReadLine()!;
            
            try
            {
                char resultLetter = Convert.ToChar(result);
                
                if(!char.IsLetter(resultLetter))
                {
                    throw new ArgumentException("Enter a valid letter!");
                }

                if (correctLetters.Contains(resultLetter) || incorrectLetters.Contains(resultLetter))
                {
                    throw new ArgumentException("You have already entered this letter!");
                }

                return Char.ToLower(resultLetter); 
            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
            }
            catch 
            { 
                WriteLine("Enter a valid letter!");
            }
        }
    }
    public static bool IsCorrectGuess(char input, string secretword)
    {
        if (secretword.Contains(input))
        {
            return true;
        }

        return false;
    }
}
