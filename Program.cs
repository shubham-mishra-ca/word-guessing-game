namespace word_guessing_game;

class Program
{
    static void Main(string[] args)
    {
        string sentence1 = "I love coding.";
        string sentence2 = "I enjoy learning.";
        Console.WriteLine(sentence1);
        Console.WriteLine(sentence2);

        int num1 = 5;
        int num2 = 10;
        int sum = num1 + num2;
        Console.WriteLine(sum);

        string name = Console.ReadLine();
        Console.WriteLine("Hello my name is " + name);

        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("I am " + age + " years old.");

        string[] names = { "John", "Jane", "Joe" };
        Console.WriteLine(names[2]);    
        }
}
