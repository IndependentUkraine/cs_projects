

using System.Xml;

namespace Homework_2
{
    internal class Program
    {
        public static void IsInRange(float number) => Console.WriteLine(number >= -5 && number <= 5 ? "is in range" : "isn`t in range");

        public static void FindMaxAndMin(int number1, int number2, int number3)
        {
            int maxNumber = Math.Max(number1, Math.Max(number2,number3));
            int minNumber = Math.Min(number1, Math.Min(number2,number3));

            Console.WriteLine($"{maxNumber} is maximum \n" +
                              $"{minNumber} is minimum");
        }
        static void Main(string[] args)
        {
            //Task 1
            float number1 = Convert.ToSingle(Console.ReadLine());
            IsInRange(number1);
            float number2 = Convert.ToSingle(Console.ReadLine());
            IsInRange(number2);
            float number3 = Convert.ToSingle(Console.ReadLine());
            IsInRange(number3);

            //Task 2
            int number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());
            int number6 = Convert.ToInt32(Console.ReadLine());
            FindMaxAndMin(number4, number5, number6);
        }
    }
}