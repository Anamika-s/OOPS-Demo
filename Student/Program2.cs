using System.Collections;

namespace StudentProject
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            string ch = "y";
            while(ch=="y")
            {
                Student student = new Student();
                student.GetDetails();
                students.Add(student);
                Console.WriteLine("wnat to add more record");
                ch = Console.ReadLine();
            }
            //students.Add(1);

            foreach (Student student in students)
            {
                if (student != null)
                {
                    student.DisplayDetails();
                }
            }
        }
    }
}