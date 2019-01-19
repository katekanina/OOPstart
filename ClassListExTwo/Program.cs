using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassListExTwo
{

    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {

        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string ('-', 15));
            numbers.Add(6);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new string('-', 15));
            numbers.Insert(1, 555);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new string('-', 15));
            numbers.RemoveAt(0);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(new string('-', 15));
            numbers.Remove(6);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();


           
            List<Person> persons = new List<Person>(4);
            persons.Add(new Person() { Name = "Sam" });

           
        }
    }
}
