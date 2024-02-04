namespace GA_Practice2_AggregateAndContainment_Hongfei
{
    internal class Program
    {
        //Week3_Practice2_AggregateAndContainment
        //Hongfei
        //02/03/2024

        static List<Student> students;
        static void Main(string[] args)
        {
            Console.WriteLine("---- Week3_Practice2_AggregateAndContainment ----");

            PopulateDatabases();


            Instructor sam = new Instructor("Sam", "Jones");
            SchoolProgram prog124 = new SchoolProgram ("Programing", "124","J102", sam);

            foreach (Student student in students)
            {
                prog124.AddStudent (student);
            }

            prog124.DisplayStudents();


            //prog124.AddStudet("lisa", "Cai", 100, 100);
            //prog124.AddStudet("Tina", "Wang", 90, 95);
            //prog124.AddStudet("Eva", "Zhang", 100, 90);

        }

        public static void PopulateDatabases()
        {
            students = new List<Student>();

            students.Add(new Student("lisa", "Cai", 100, 100));
            students.Add(new Student("Tina", "Wang", 90, 95));
            students.Add(new Student("Eva", "Zhang", 100, 90));

        }




    }
}
