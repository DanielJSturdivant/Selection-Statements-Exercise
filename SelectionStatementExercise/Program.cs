namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise Number 1

            int favoriteNumber = 4;

            Console.WriteLine("Guess the favorite number. Hint: Less than 24");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("You guessed too low!");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("You guessed too high!");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You guessed correctly.");
            }
            else
            {
                Console.WriteLine("Maybe you should try again.");
            }

            //Exercise Number 2

            string subject = "C#";

            Console.WriteLine("Please choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class.");
                    break;
                case "Java":
                    Console.WriteLine("We are being taught C#, not Java.");
                    break;
                case "English":
                    Console.WriteLine("English is not the right class.");
                    break;
                case "Math":
                    Console.WriteLine("Go down the hall. Math isn't taught here.");
                    break;
                case "Science":
                    Console.WriteLine("We aren't teaching science here.");
                    break;
                default:
                    Console.WriteLine("Are you sure that's the right subject?");
                    break;

            }
        }
    }
}
