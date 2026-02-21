namespace COMP003A.LectureActivity6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Alex", 20);
            Student student2 = new Student("Jordan", 22);
            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.WriteLine();

            student1.Age = 100;
            student1.DisplayInfo();
            student2.DisplayInfo();

            //Part F
            // 1. Each Student object has its own data, because each object stores its own set of values.
            // 2. Main doesn't need to know how DisplayInfo works, because that logic stays inside the Student class
            // 3. This shows encapsulation, because the object handles its own data and methods, and the Main just uses it.
        }
    }
}
