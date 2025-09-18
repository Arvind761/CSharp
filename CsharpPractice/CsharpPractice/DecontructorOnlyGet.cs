using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class Teacher
    {
        int id;
        string name, job;
        public Teacher(int id, string name, string job)
        {
            this.id = id;
            this.name = name;
            this.job = job;
        }
        public void Deconstruct(out int id, out string name, out string job)
        {
            id = this.id;
            name = this.name;
            job = this.job;

        }
        public void Deconstruct(out int id, out string name)
        {
            id = this.id;
            name = this.name;
            

        }
    }
    internal class DecontructorOnlyGet
    {
        public static void Main(string[] args) {
            Teacher t = new Teacher(101, "Radha", "HR");

            (int Id, string Name, string Job) = t;
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee Job: {Job}");
            Console.WriteLine();

            var (Id1,Name1) = t;
            Console.WriteLine($"Employee Id: {Id1}");
            Console.WriteLine($"Employee Name: {Name1}");

             

        }
    }
}
