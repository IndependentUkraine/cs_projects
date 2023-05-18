namespace Homework_6
{
    internal class Program
    {
        public static int Div(int a, int b) => a / b;

        public static int ReadNumber(int start, int end)
        {
            Console.Write("Enter the value: ");
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
                throw new Exception($"The number should be in range {start} ... {end}");

            return number;
        }
        static void Main(string[] args)
        {
            //Task 1
            try
            {
                Console.Write("Enter number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter number: ");
                int num2 = int.Parse(Console.ReadLine());

                Div(num1, num2);
            }
            catch (DivideByZeroException ex) { Console.WriteLine(ex.Message); }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
            catch (OverflowException ex) { Console.WriteLine(ex.Message); }
            catch (NullReferenceException ex) { Console.WriteLine(ex.Message); }



            //Task 2

            Console.Write("Enter start: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; )
            {
                try
                {
                    numbers[i] = i == 0 ? ReadNumber(start, end): ReadNumber(numbers[i - 1], end);
                    i++;
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            
        }
    }
}