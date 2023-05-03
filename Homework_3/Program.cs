namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            int amount_A = 0, amount_O = 0, amount_I = 0, amount_E = 0;

            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            foreach (char c in str.ToLower())
            { 
                if(c == 'a') amount_A++;
                else if(c == 'o') amount_O++;
                else if (c == 'i') amount_I++;
                else if (c == 'e') amount_E++;
            }

            Console.WriteLine($"a: {amount_A}, o: {amount_O}" +
                $" i: {amount_I}, e: {amount_E}");

            //Task 2

            Console.Write("Enter the number of month: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Count of days: " +
                $"{DateTime.DaysInMonth(DateTime.Now.Year, number)}");

        }
    }
}