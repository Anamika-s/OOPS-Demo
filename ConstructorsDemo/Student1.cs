using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Demo
{
    internal class Student
    {
        int rn;
        string name;
        static string batch;
        int score;
        public const string CollegeName = "Amity";

        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
            //Console.WriteLine("enter batch");
            //batch = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("rn is " + rn);
            Console.WriteLine("name is " + name);
            Console.WriteLine("Score is " + score);
            //Console.WriteLine("batch is " + batch);
            //Console.WriteLine("collegeName is " + collegeName);
        }
        public static void BatchDetails()
        {
            Console.WriteLine("Batch is "+ batch);
        }

        // def const
        public Student() { }

        // para const
        public Student(int rn)
        {
            this.rn = rn;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        // para const
        public Student(int rn, string name)
        {
            this.rn = rn;

            this.name = name;
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        // fully para const
        public Student(int rn, string name, int score)
        {
            this.rn = rn;
            this.name = name;
            this.score = score;

        }
        // static const
        // can be 1 only, shud be parameterless
        // with no access specifier
        static Student()
        {
            batch = "DotNet React";
        }
        // copy const
        public Student(Student obj)
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());

            name = obj.name;
            score = obj.score;
        }
        
    }
}







