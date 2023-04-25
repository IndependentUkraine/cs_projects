namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.Write("Enter the square side length (cm): ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine($"Square area: {a * a} cm^2");
            Console.WriteLine($"Square perimeter: {a * 4} cm");

            // Task 2
            Console.Write("What is your name? : ");
            string name = Console.ReadLine();
            Console.Write($"How old are you, {name}? : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"{name}, you`re {age} years old");

            //Task 3
            Console.Write("Enter radius of circle (cm): ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"Length of a circle : {2 * Math.PI * r} cm");
            Console.WriteLine($"Area of a circle : {Math.PI * r * r}  cm^2");
            Console.WriteLine($"Volume of a circle : {4.0/3 * Math.PI * r * r * r}  cm^3");
        }
    }
}