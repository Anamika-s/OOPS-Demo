namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student;
            //student = new Student();
            Student student = new Student();
            // new keyword will do 2 things
            // 1. it allocates memory on heap
            // 2. it will call constructor that is used
            // to initialize member variables
            student.GetDetails();
            student.DisplayDetails();


        }
    }
}
