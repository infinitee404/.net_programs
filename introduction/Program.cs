using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            double height = 1.70;
            char first = 'A';
            bool isMale = true;
            string name = "Anudit";

            const double PI = 3.1415;
            
            if (age <= 18)
            {
                Console.WriteLine($"{name} is a child");
            }
            else
            {
                Console.WriteLine($"{name} is an adult");
            }

            Console.WriteLine($"Name: {name} \nHeight: {height}");

            Console.WriteLine("The value of Pi is: " + PI);

            for (int i=0; i<5; i++)
            {
                Console.WriteLine("The value of i is: " + i);
            }

            int j = 5;
            while (j > 0)
            {
                Console.WriteLine("The decreasing value of i is: " + j);
                j--;
            }

            void Greet()
            {
                Console.WriteLine("Hello user!");
            }
            Greet();

            int x = 5;
            int y = 10;
            void Add(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("The sum is: "+ sum);
            }
            Add(x, y);

            void Prod(int g, int h)
            {
                int prod = g * h;
                Console.WriteLine("The product is: " + prod);
            }
            Prod(x, y);

            int Diff(int p, int q)
            {
                int diff = p - q;
                return diff;
            }

            int sub = Diff(y, x);
            Console.WriteLine("The difference is: "+sub);
        }
    }
}
