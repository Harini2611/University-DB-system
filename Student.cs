using System;
using System.Collections.Generic;
using System.Text;

namespace N01419700_Assignment1
{
    class Student : Person
    {
        //member variables
        private List<Course> courses;//List of courses the student's taking
        private string major; //private variable for the major the student's taking

        //member functions
        public Student(int id, string name, string major):base(id,name)//Constructor for initializing variables
        {
            this.major = major;
            courses = new List<Course>();//Created course object and added to List of courses
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);//Adding course to the List courses
        }

        public List<Course> GetCourses()
        {
            return courses;//returning courses variable
        }

        public string GetMajor()
        {
            return major;//returning major variable
        }
    }
}
