using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    internal class Student
    {
        int rn;
        string name;
        string batch;
        int score;
        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter batch");
            batch = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("rn is " + rn);
            Console.WriteLine("name is " + name);
            Console.WriteLine("batch is " + batch);
            Console.WriteLine("score is " + score);
        }
    }
}