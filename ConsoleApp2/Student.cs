using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Student:Human
    {
        public Student(string name,string surname) : base(name, surname)
        {

        }
        public int Grade;
        public int GroupNo;
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}-SurName:{SurName}");
        }


    }
}
