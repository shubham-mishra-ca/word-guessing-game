namespace word_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                WordGuessingGame game = new WordGuessingGame();
                game.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }

    class WordGuessingGame
    {
        private Random rand;
        private string[] words;
        private string wordToGuess;
        private bool hasWon;
        private int guesses;

        public void Start()
        {
            Initialize();
            PlayGame();
            DisplayResult();
        }

        private void Initialize()
        {
            // Create a new instance of Random class for generating random numbers
            rand = new Random();

            // Define an array of words to guess
            words = new string[] { "apple", "banana", "orange", "pear" };
            
            // Randomly select a word from the array
            if (words.Length > 0)
            {
                wordToGuess = words[rand.Next(0, words.Length)];
            }
            else
            {
                Console.WriteLine("No words available to guess.");
                return;
            }
            // Initialize a flag to track if the player has won
            hasWon = false;

            // Calculate the maximum number of guesses allowed
            guesses = words.Length / 2;
        }

        private void PlayGame()
        {
            for (int i = 0; i < guesses; i++)
            {
                // Prompt the player to guess the word
                Console.WriteLine("Guess the word: ");

                // Display the available words for reference
                DisplayAvailableWords();

                // Display the number of remaining tries
                Console.WriteLine("Tries left: " + (guesses - i));
                Console.WriteLine();

                // Read the player's guess from the console
                string guess = Console.ReadLine();

                // Check if the guess is empty or null
                if (string.IsNullOrEmpty(guess))
                {
                    Console.WriteLine("Invalid guess. Please enter a valid word.");
                    i--; // Decrement i to repeat the current iteration
                    continue;
                }
                // Check if the guess matches the word to be guessed
                if (guess == wordToGuess)
                {
                    hasWon = true;
                    break;
                }
            }
        }

        private void DisplayAvailableWords()
        {
            // Display the available words for reference
            foreach (string word in words)
            {
                Console.WriteLine(word + " ");
            }
        }

        private void DisplayResult()
        {
            // Display the result of the game
            if (hasWon)
            {
                Console.WriteLine("You guessed the correct word! You Won!!");
            }
            else
            {
                Console.WriteLine("Sorry, you did not win this time :( .The word was: " + wordToGuess);
            }
        }
    }
}
