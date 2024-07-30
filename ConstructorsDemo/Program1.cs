namespace Constructors_Demo
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.CollegeName);
            Student.BatchDetails();

            // this will invoke def const
            Student student1 = new Student(); 
            student1.GetDetails();
            student1.DisplayDetails();

            // this will invoke para const
            Student student2 = new Student(rn:10);
            student2.DisplayDetails();

            // this will invoke para const
            Student student3 = new Student(rn:11,
                name: "Deepak Kumar");
            student3.DisplayDetails();

            // this will invoke para const
            Student student4 = new Student(20,
                "jatin", 90);
            student4.DisplayDetails();

            // this will invoke copy const
            Student student5 = new Student(student3);
            student5.DisplayDetails();






        }
    }
}
