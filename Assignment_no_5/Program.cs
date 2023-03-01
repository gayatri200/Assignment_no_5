using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_no_5
{
    internal class Program
    {
        //AssignmentNo5
        // 1. Create an Abstract class Student with Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which takes grade as an input and checks whether student passed the course or not.

        //Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method

        //For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
        public abstract class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

            public abstract bool IsPassed(double grade);
        }

        public class Undergraduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 70.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                if (grade > 80.0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        //2.  Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() as its method.

        //    -Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.

        //    - Each class should have its own fields/properties like float fees(Day Scholar - it is 50000/- and for Resident it is 100000/-. 

        //    -ShowDetails() should show DaysScholar details and Resident Details accordingly.

        public interface IStudent
        {
            int StudentId { get; set; }
            string Name { get; set; }
            void ShowDetails();
        }

        public class Dayscholar : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public float Fees { get; set; } = 50000;

            public void ShowDetails()
            {
                Console.WriteLine($"Dayscholar: Student Id = {StudentId}, Name = {Name}, Fees = {Fees}");
            }
        }

        public class Resident : IStudent
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
            public float Fees { get; set; } = 100000;

            public void ShowDetails()
            {
                Console.WriteLine($"Resident: Student Id = {StudentId}, Name = {Name}, Fees = {Fees}");
            }
        }



        static void Main(string[] args)
        {
            
            Resident resident = new Resident();
            resident.StudentId = 2001;
            resident.Name = "gayatri";
            resident.Fees = 100000;
            resident.ShowDetails();

            //Dayscholar dayscholar = new Dayscholar();
            //dayscholar.StudentId = 2001;
            //dayscholar.Name = "anchal";
            //dayscholar.Fees = 200000;



            Console.Read();
        }
    }
}
