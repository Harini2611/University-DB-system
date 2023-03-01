using System;
using System.Linq;

namespace N01419700_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            University uni = new University("Umber");//Created an object for university
            //Adding 5 students to the University
            Console.WriteLine("Adding students");
            uni.AddPerson(new Student(1234, "Raita Mansala", "Zoology"));
            uni.AddPerson(new Student(2345, "Dal Tadkaya", "Botany"));
            uni.AddPerson(new Student(3456, "Pavan Bhaji", "Astronomy"));
            uni.AddPerson(new Student(5432, "Kareem Brulesh", "Nuclear Physics"));
            uni.AddPerson(new Student(9845, "Manch Chorhean", "Psychology"));

            Console.WriteLine();
            //Adding 3 instructors to the University
            Console.WriteLine("Adding instructors");
            Instructor inst1 = new Instructor(1928, "Jolly Johnji");
            uni.AddPerson(inst1);
            Instructor inst2 = new Instructor(1815, "Tony Marshall");
            uni.AddPerson(inst2);
            Instructor inst3 = new Instructor(8291, "Jolly Johnji Jr.");
            uni.AddPerson(inst3);

            Console.WriteLine();
            //Adding 3 courses to the University
            Console.WriteLine("Adding courses");
            Course crs1 = new Course(281827, "Particle Physics");
            uni.AddCourse(crs1);
            Course crs2 = new Course(618299, "Behavioural Neuroscience");
            uni.AddCourse(crs2);
            Course crs3 = new Course(281094, "Animal neurobiology");
            uni.AddCourse(crs3);

            Console.WriteLine();
            //Assigning Instructors to courses
            inst1.SetCourse(crs3);
            inst2.SetCourse(crs1);
            inst3.SetCourse(crs2);

            Console.WriteLine();
            //Printing University name
            Console.WriteLine("The name of the University is {0}" , uni.GetName());

            Console.WriteLine();
            //Printing Total University population
            Console.WriteLine("The total number of persons in the University are {0}", uni.GetNumPeople());

            Console.WriteLine();
            //Printing a list of students in the University 
            Console.WriteLine("Printing list of students");
            foreach (var student in uni.GetPeople().OfType<Student>())
            {
                Console.WriteLine("Student id {0}, Student name {1}, Student major {2}", student.GetId(), student.GetName(), student.GetMajor());
            }

            Console.WriteLine();
            //Printing a list of instructors in the University 
            Console.WriteLine("Printing list of instructors");
            foreach (var instructor in uni.GetPeople().OfType<Instructor>())
            {
                Console.WriteLine("Instructor id {0}, Instructor name {1}, Instructor course {2}", instructor.GetId(), instructor.GetName(), instructor.GetCourse());
            }

            Console.WriteLine();
            // Printing Total University courses available 
            Console.WriteLine("The total number of courses in the University are {0}", uni.GetNumCourses());

            Console.WriteLine();
            //Printing courses with numbers and names
            Console.WriteLine("Printing list of courses");
            foreach (var course in uni.GetCourses())
            {
                Console.WriteLine("Course number {0}, Course name {1}", course.GetNumber(), course.GetName());
            }

            Console.WriteLine();
            //Finding a person by ID
            Person foundPerson = uni.FindPerson(1928);
            Console.WriteLine("Name of the person found is {0}", foundPerson.GetName());

            Console.WriteLine();
            //Removing a person by ID
            uni.RemovePerson(8291);

            Console.WriteLine();
            //Printing a list of everyone to verify deletion
            Console.WriteLine("Printing list of people");
            foreach (var person in uni.GetPeople())
            {
                Console.WriteLine("Person name {0}", person.GetName());
            }


        }
    }
}
