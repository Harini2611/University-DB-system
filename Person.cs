using System;
using System.Collections.Generic;
using System.Text;

namespace N01419700_Assignment1
{
    class Person
    {
        //member variables
        private string name; //private variable for name of the person.
        private int id; //private variable for the id number of the person.

        //member functions
        public Person(int id, string name) //Constructor for initializing variables
        {
            this.id = id;
            this.name = name; 
        }

        public string GetName()
        {
            return name; //GetName returns the value of name.
        }

        public int GetId()
        {
            return id; //GetId returns the value of Id.
        }

    }

}
