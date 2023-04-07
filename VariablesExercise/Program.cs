namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           string dogName; //Declaration syntax

            dogName = "duke"; //Initialized --- assigning a value

            int dogAge = 6; //Declaring and Initializing

            char firstInitial = 'D';

            bool isStarving = true;

            double dogWeight = 45;

            decimal dogHeight = 14.7m;

            Console.WriteLine($"Hello! My dog's name is {dogName}, his initial is {firstInitial}, and he is {dogAge} years old.");
            Console.WriteLine($"He weighs {dogWeight} pounds and he is {dogHeight} inches tall.");
            Console.WriteLine($"It is {isStarving} he is always hungry.");
        }
    }
}
