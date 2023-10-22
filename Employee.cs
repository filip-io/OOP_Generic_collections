using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generic_collections
{
    internal class Employee
    {
        // Declaration of class properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }


        // Class constructor
        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }


        // Used to override the build in ToString() method in the Employee class to return a custom string
        public override string ToString()
        {
            return $"{Id} - {Name} - {Gender} - {Salary}";
        }
    }
}
