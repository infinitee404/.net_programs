using System;

namespace ClassIntro
{
    class Student
    {
        public string Name;
        public int Age;
        public string Major;

        // constructor has same name as the class name
        public Student() //default constructor
        {
            Name = "Bone Apple Tea";
            Age = 7;
            Major = "N/A";
        }

        public Student(string name, int age, string major) //parameterized constructor
        {
            Name = name;
            Age = age;
            Major = major;
        }

    }

    class Rectangle
    {
        private int height;
        private int width;

        public int Height
        {
            get { return height; }
            set { height = value < 0 ? 0 : value; }
        }
        
        public int Width
        {
            get { return width; }
            set { width = value < 0 ? 0 : value; }
        }

        public int Area
        {
            get { return height * width; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();  //default constructor is called. Sets default values.
            Student S2 = new Student("John Doe", 17, "Computing");

            Console.WriteLine("Student 1:");
            Console.WriteLine("Name: " + S1.Name);
            Console.WriteLine("Age: " + S1.Age);
            Console.WriteLine("Major: " + S1.Major);
            Console.WriteLine();
            Console.WriteLine("Student 2:");
            Console.WriteLine("Name: " + S2.Name);
            Console.WriteLine("Age: " + S2.Age);
            Console.WriteLine("Major: " + S2.Major);
            Console.WriteLine();

            Rectangle R1 = new Rectangle();
            R1.Height = 10;
            R1.Width = 5;

            Console.WriteLine("Rectangle Properties:");
            Console.WriteLine("Height: " + R1.Height);
            Console.WriteLine("Width: " + R1.Width);
            Console.WriteLine("Area: " + R1.Area);
            Console.WriteLine();
        }
    }
}
