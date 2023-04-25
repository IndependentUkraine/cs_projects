namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.Write("Enter the square side length (cm): ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine($"Square area: {a * a}cm^2");
            Console.WriteLine($"Square perimeter: {a * 4}cm");

            
        }
    }
}