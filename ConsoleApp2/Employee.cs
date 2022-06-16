using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Employee:Human
    {
        public Employee(string name,string surname) : base(name, surname)
        {

        }
        public string Position;
        public  void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}-Surname:{SurName}-Position:{Position}");
        }
    }
}
