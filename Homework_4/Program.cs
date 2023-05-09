using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace Homework_4
{
    class Person
    {
        private string? name;
        private DateTime birthYear;

        public string? Name => name;
        public DateTime BirthYear => birthYear;

        public Person() { }
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age() => DateTime.Now.Year - this.birthYear.Year;

        public void Input()
        {
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            this.birthYear = DateTime.Parse(Console.ReadLine());
        }

        public void ChangeName(string name) { this.name = name; }

        public override string ToString()
        {
            return $"Person: {Name}, {BirthYear.ToShortDateString()}";
        }

        public void Output() { Console.WriteLine(ToString()); }

        public static bool operator ==(Person pers1, Person pers2)
        {
            return pers1.Name == pers2.Name;
        }

        public static bool operator !=(Person pers1, Person pers2)
        {
            return pers1.Name != pers2.Name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[6]
            {
            new Person("David", new DateTime(2003,12, 25)),
            new Person("Andriy", new DateTime(2003, 9, 30)),
            new Person("Stewie", new DateTime(2004, 4, 9)),
            new Person("John", new DateTime(1998, 6, 7)),
            new Person("David", new DateTime(2000, 5, 3)),
            new Person("Oleh", new DateTime(2010, 1, 15))
            };

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name}, {person.Age()} years old");
            }
            Console.WriteLine("-----------------------------");

            foreach (Person person in persons)
                if (person.Age() < 16)
                    person.ChangeName("Very young");

            foreach (Person person in persons) person.Output();

            Console.WriteLine("--------------------------");

            foreach (Person person in persons)
            {
                int count = 0;
                foreach (Person person2 in persons)
                {
                    if (person == person2)
                    {
                        count++;
                        if (person.BirthYear != person2.BirthYear)
                            Console.WriteLine($"{person} namesake ==> {person2}");
                    }
                }

                if (count == 1)
                    Console.WriteLine($"{person} has no namesakes");
            }

        }
    }
}