
    class Program
    {
        static void Main(string[] args)
        {
            // Creating first object
            Student student1 = new Student();

            student1.name = "Dilip";
            student1.age = 20;
            student1.address = "Itahari";

            // Creating second object
            Student student2 = new Student();

            student2.name = "Ram";
            student2.age = 21;
            student2.address = "Kathmandu";

            // Display first student
            Console.WriteLine("Student 1:");
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.age);
            Console.WriteLine(student1.address);

            // Display second student
            Console.WriteLine("\nStudent 2:");
            Console.WriteLine(student2.name);
            Console.WriteLine(student2.age);
            Console.WriteLine(student2.address);

            // Display static field
            Console.WriteLine("\nCollege: " + Student.college);
        }
    }
