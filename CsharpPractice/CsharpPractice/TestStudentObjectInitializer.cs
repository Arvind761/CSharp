using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class Student
    {
        int? _id, _class;
        string _name;
        double? _marks, _fee;

        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int? Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double? Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }
        public double? Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        public override string ToString()
        {
            return $" Id: {Id}\n Class: {Class}\n Name: {Name}\n Marks: {Marks}\n Fee: {Fee}\n";
        }
    }
    internal class TestStudentObjectInitializer
    {
        public static void Main(string[] args)
        {
            Student st1 = new Student
            {
                Id = 101,
                Class = 10,
                Name = "Arvind",
                Marks = 80,
                Fee = 30000
            };
            Student st2=new Student
            {
                Id = 101,
                Class = 10,
                Name = "Arvind",
                Marks = 80,
                Fee = 30000
            };
            Student st3=new Student
            {
                Id = 101,
                Class = 10,
                Name = "Arvind",
                Marks = 80,
                Fee = 30000
            };
            Console.WriteLine($"Student Details {st1}");
            Console.WriteLine($"Student Details {st2}");
            Console.WriteLine($"Student Details {st3}");
        }


    }
}
