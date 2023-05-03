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
                if (c == 'a') amount_A++;
                else if (c == 'o') amount_O++;
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

            //Task 3
            int arraySize = 10;
            int[] numbers = new int[arraySize];

            for(int i = 0; i < arraySize; i++)
            {
                Console.Write("Enter number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool isNegative = false;

            for (int i = 0; i < 5; i++)
                if (numbers[i] < 0)
                    isNegative = true;

            if (isNegative)
            {
                int product = 1;
                for (int i = 5; i < arraySize; i++)
                    product *= numbers[i];
                Console.WriteLine($"Product: {product}");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                    sum += numbers[i];
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}