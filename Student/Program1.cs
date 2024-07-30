namespace StudentProject
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student();
            //Student student2 = new Student();
            //student1.GetDetails();
            //student2.GetDetails();
            //student1.DisplayDetails();
            //student2.DisplayDetails();
            // ARRAY OF OBJECTS
            Student[] students = new Student[10];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"enter details of student no {i + 1}");
                students[i] = new Student();
                students[i].GetDetails();
            }
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