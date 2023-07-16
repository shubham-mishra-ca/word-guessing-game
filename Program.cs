namespace word_guessing_game;

class Program
{
    static void Main(string[] args)
    {
        
           Random rand = new Random();      // Create a new instance of Random class for generating random numbers
           string[] words = { "apple", "banana", "orange", "pear" };   // Define an array of words to guess
           string wordToGuess = words[rand.Next(0,words.Length)];  // Randomly select a word from the array

           bool hasWon = false;         // Initialize a flag to track if the player has won

           int guesses = words.Length/2;        // Calculate the maximum number of guesses allowed

            // Loop through the guesses
           for(int i=0; i< guesses; i++)
           {
                Console.WriteLine("Guess the word: ");      // Prompt the player to guess the word

                // Display the available words for reference
                for(int j=0 ; j< words.Length; j++){
                    Console.WriteLine(words[j] + " ");
                }
                
                // Display the number of remaining tries
                Console.WriteLine("Tries left: "+ (guesses - i));
                Console.WriteLine();

                // Read the player's guess from the console
                string guess = Console.ReadLine();

                // Check if the guess matches the word to be guessed
                if(guess == wordToGuess){
                    hasWon = true;          // Set the flag to indicate the player has won and break out of the loop
                    break;
                }
           }

           // Display the result of the game
            if(hasWon){
                Console.WriteLine("You guessed the correct word! You Won!!");
            }else{
                Console.WriteLine("Sorry, you did not win this time :( .The word was: "+ wordToGuess);
            }
           
    }
}
