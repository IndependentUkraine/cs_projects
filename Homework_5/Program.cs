using System.ComponentModel;
using System.Numerics;

namespace Homework_5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        public string? Tool { get; set; }

        public void Create();
        public void Destroy();

        int IComparable<IDeveloper>.CompareTo(IDeveloper? other)
        {
            return this.Tool.Length.CompareTo(other.Tool.Length);
        }
    }

    class Programmer : IDeveloper
    {
        private string? language;

        public string? Tool { get { return language; } set { language = value; } }

        public void Create()
        {
            Console.WriteLine($"Programming is creating sth using {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programming is destroying sth using {Tool}");
        }
    }

    class Builder : IDeveloper
    {
        private string? tool;

        public string? Tool { get { return tool; } set { tool = value; } }

        public void Create()
        {
            Console.WriteLine($"Builder is creating sth using {Tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder is destroying sth using {Tool}");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            IDeveloper[] developers = new IDeveloper[]
            {
                new Programmer() {Tool = "c#" },
                new Builder() { Tool = "hammer" },
                new Programmer() { Tool = "c++" },
                new Builder() { Tool = "power drill" },
                new Programmer() { Tool = "python" },
                new Builder() { Tool = "saw" },
                new Programmer() { Tool = "java" },
                new Builder() { Tool = "screwdriver" }
            };

            Array.Sort(developers);
            foreach (IDeveloper dev in developers)
            {
                dev.Create();
                dev.Destroy();
            }
            Console.WriteLine("-------------------------");

            // Task 2
            Dictionary<uint, string> persons = new Dictionary<uint, string>();

            uint ID;
            string? name;
            bool isFound = false;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter id: ");
                ID = uint.Parse(Console.ReadLine());
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                persons.Add(ID, name);
            }

            Console.WriteLine("-----------------");
            Console.Write("Enter ID: ");
            ID = uint.Parse(Console.ReadLine());

            foreach (var person in persons)
            {
                if (person.Key == ID)
                {
                    Console.WriteLine(person.Value);
                    isFound = true;
                }
            }

            if (isFound == false)
                Console.WriteLine($"I can`t find a user with ID - {ID}");
        }
    }
}