using System;
using System.Collections.Generic;
using System.Text;

namespace N01419700_Assignment1
{
    class Instructor : Person//Inheriting base class
    {
        //member variable
        private Course course;

        //member functions
        public Instructor(int id, string name):base(id,name)
        {
          
        }

        public void SetCourse(Course course)
        {
            this.course = course;//sets the value of course to the arguement 
        }

        public Course GetCourse()
        {
            return course;//returning course object
        }
    }
}
