using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    public class Employee
    {
        int _id;
        string _name,_job;
        double _salary;
        bool _status;

        public Employee(int id)
        {
            _id = id;
            _name = "arvind";
            _job = "Developer";
            _salary = 50000;
            _status = false;

        }
        #region Indexer1
        public object this[int index]
        {
            get
            {
                if (index == 1)
                    return _id;
                else if (index == 2)
                    return _name;
                else if (index == 3)
                    return _job;
                else if (index == 4)
                    return _salary;
                else if (index == 5)
                    return _status;
                else
                    return null;
            }
            set
            {
                if (index == 1)
                    _id = (int)value;
                else if (index == 2)
                    _name = (string)value;
                else if (index == 3)
                    _job = (string)value;
                else if (index == 4)
                    _salary = (double)value;
                else if (index == 5)
                    _status = (bool)value;
            }
        }
        #endregion

        #region Indexer2
        public object this[string Name]
        {
            get
            {
                if (Name == "id")
                    return _id;
                else if (Name == "Name")
                    return _name;
                else if (Name == "Job")
                    return _job;
                else if (Name == "Salary")
                    return _salary;
                else if (Name == "Status")
                    return _status;
                else
                    return null;
            }
            set
            {
                if (Name == "id")
                    _id = (int)value;
                else if (Name == "Name")
                    _name = (string)value;
                else if (Name == "Job")
                    _job = (string)value;
                else if (Name == "Salary")
                    _salary = (double)value;
                else if (Name == "Status")
                    _status = (bool)value;
            }
        }
        #endregion
    }
    internal class IndexersTest
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee(1005);
            Console.WriteLine($"Employee id: {emp[1]}");
            Console.WriteLine($"Employee Name: {emp[2]}");
            Console.WriteLine($"Employee Job: {emp[3]}");
            Console.WriteLine($"Employee Salary: {emp[4]}");
            Console.WriteLine($"Employee Status: {emp[5]}");

            emp[3] = "sr Manager";
            emp["id"] = 10023;

            
            Console.WriteLine($"Employee id: {emp["id"]}");
            Console.WriteLine($"Employee Name: {emp["Name"]}");
            Console.WriteLine($"Employee Job: {emp["Job"]}");
            Console.WriteLine($"Employee Salary: {emp["Salary"]}");
            Console.WriteLine($"Employee Status: {emp["Status"]}");


            Console.ReadLine();


        }
    }
}
