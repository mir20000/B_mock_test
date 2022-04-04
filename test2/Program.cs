using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{

   public class Student
    {
        private string course;
        private int feepaid;
        private string name;
        private int rollno;
        private static double servicetax = 12.3;


        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total =  course == "c#" ? 2000 : course == "asp.net" ? 3000 : 0;

                total = total + total * servicetax / 100;
                return (int)total;
            }
        }

        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

    }
    class UseStudent
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "ABC", "asp.net");
            s.Payment(1000);
            s.Print();
            Console.WriteLine(s.DueAmount);
            Console.ReadKey();
        }
    }
}
