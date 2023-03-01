using System;
using System.Collections.Generic;
using System.Text;

namespace N01419700_Assignment1
{
    class Course
    {
        //member variables
        private string name;//private variable for the name of the course
        private int number;//private variable for the course number

        //member functions
        public Course(int number, string name)//Constructor for initializing variables
        {
            this.number = number;
            this.name = name;
        }

        public string GetName()
        {
            return name; //GetName returns the value of name.
        }

        public int GetNumber()
        {
            return number; //GetNumber returns the value of Number.
        }
    }
}
