using System.Threading.Channels;

namespace Homework_2
{
    internal class Program
    {
        public static void IsInRange(float number) => Console.WriteLine(number >= -5 && number <= 5 ? "is in range" : "isn`t in range");
        static void Main(string[] args)
        {
            //Task 1
            float number1 = Convert.ToSingle(Console.ReadLine());
            IsInRange(number1);
            float number2 = Convert.ToSingle(Console.ReadLine());
            IsInRange(number2);
            float number3 = Convert.ToSingle(Console.ReadLine());
            IsInRange(number3);


        }
    }
}