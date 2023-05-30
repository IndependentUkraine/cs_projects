using System.Runtime.InteropServices;

namespace Homework_9
{
    public delegate void MyDel(int m);

    class Student
    {
        private string name;
        private List<int> marks = new List<int>();

        public Student(string name)
        { 
            this.name = name;
        }

        public event MyDel MarkChange;
        public void AddMark(int mark)
        { 
            marks.Add(mark);
            if (MarkChange != null) MarkChange(mark);
        }
    }
    class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine($"Son/daughter, i saw your last mark {mark} in your diary");
        }

    }

    class Accountancy
    {
        private List<int> marks = new List<int>();

        public void PayingFellowship(int mark)
        {
            marks.Add(mark);
            Console.WriteLine($"Student will {((marks.Count() * 3 <= marks.Sum()) ? "have" : "not have")} a scholarship");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("John");
            Parent parent = new Parent();
            Accountancy acc = new Accountancy();

            stud.MarkChange += parent.OnMarkChange;
            stud.MarkChange += acc.PayingFellowship;

            stud.AddMark(3);
            stud.AddMark(2);
            stud.AddMark(3);
            stud.AddMark(5);
            stud.AddMark(5);



        }
    }
}