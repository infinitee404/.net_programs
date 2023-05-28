using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Fullname is: " + fullName);

            string check = "Hello World!";

            int length = check.Length;
            string substr = check.Substring(1, 7);
            int index = check.IndexOf("or");
            string changedMessage = check.Replace("Hello", "Howdy");
            string newString = "My name is John Doe.";
            string[] parts = newString.Split(' ');

            Console.WriteLine("The new string is: " + check);
            Console.WriteLine("The length of the string is: " + length);
            Console.WriteLine("A substring from the string is: " + substr);
            Console.WriteLine("The position of 'or' in given string is: " + index);
            Console.WriteLine("Replaced the greeting word: " + changedMessage);
            Console.WriteLine("A new string that will be split: " + newString);
            foreach (string word in parts)
            {
                Console.Write(word + ", ");
            }
            
        }
    }
}
