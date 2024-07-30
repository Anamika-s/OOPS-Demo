using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    internal class Student
    {
        int rn;
        string name;
        public static string batch="B001";
        int score;
        public const string collegeName = "Amity";

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
            batch = "DotNet Training";
            Console.WriteLine("Batch is " + batch);
        }











    }
}
