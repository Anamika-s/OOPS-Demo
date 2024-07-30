namespace ConstructorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Student.collegeName);
            //Student.batch = "DotNet React";
            //Console.WriteLine(Student.batch);
            Student.BatchDetails();

            Student student1 = new Student();
            student1.GetDetails();
            student1.DisplayDetails();
            Student student2 = new Student();
            student2.GetDetails();
            student2.DisplayDetails();
        }
    }
}
