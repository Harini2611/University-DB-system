using System;
using System.Collections.Generic;
using System.Text;

namespace N01419700_Assignment1
{
    class University
    {
        //member variable
        private List<Person> people;
        private string name;
        private List<Course> courses;

        //member functions
        public University(string name)//Constructor for initializing variables
        {
            this.name = name;
            people = new List<Person>();//created list for people
            courses = new List<Course>();//created list for courses
        }

        public void AddPerson(Person person)
        {
            people.Add(person);//added a person to people
            Console.WriteLine("Person {0} has been added", person.GetName());
        }

        public List<Person> GetPeople()
        {
            Console.WriteLine("Returning List of People");
            return people;//returning people variable
        }

        public int GetNumPeople()
        {
            Console.WriteLine("People.count = {0}", people.Count);
            return people.Count;//returns the size of the people list
        }

        public void AddCourse(Course course)
        {
            Console.WriteLine("Course {0} has been added", course.GetName());
            courses.Add(course);//added a course to courses
        }

        public int GetNumCourses()
        {
            Console.WriteLine("courses.count = {0}", courses.Count);
            return courses.Count;//returns the size of the course list
        }

        public List<Course> GetCourses()
        {
            Console.WriteLine("Returning List of Courses");
            return courses;//returning courses variable
        }

        public string GetName()
        {
            Console.WriteLine("Returning name {0}", name);
            return name;//returning name variable
        }

        public Person FindPerson(int id)
        {
            foreach (Person person in people)
            {
                if (person.GetId() == id)
                {
                    Console.WriteLine("Found person with id {0}" , id);
                    return person; //Created a foreach loop to find the person whose id=id
                }
            }
            Console.WriteLine("Person with id {0} could not be found", id);
            return new Person(-1, "");
        }

        public Boolean RemovePerson(int id)
        {
            foreach (Person person in people)
            {
                if (person.GetId() == id)
                {
                    Console.WriteLine("Removed person with id {0}", id);
                    return people.Remove(person);//removing person from people using id=id
                }
            }
            Console.WriteLine("Person with id {0} could not be found", id);
            return false;
        }
    }
}
