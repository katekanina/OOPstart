using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGetEx
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            set{name = value;}
            get{return name;}
        }

        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Impossible");
                    Console.ReadKey();
                }
                else
                {
                    age = value;
                   // Console.WriteLine($"Hello, {value},  ages.");
                   // Console.ReadKey();
                }
               
            }
            get{return age;}
        }
        public void SayHello(string nameKey, int ageKey)
        {


            
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();
            Person personTwo = new Person();
            personOne.Name = "Sam";
            personOne.Age = 15;
            personTwo.Name = "Ann";
            personTwo.Age = 25;
            

            Console.WriteLine($"Hello, {personOne.Name}, {personOne.Age} ages");
            Console.WriteLine($"Hello, {personTwo.Name}, {personTwo.Age} ages" );
            Console.ReadKey();
            // personOne.SayHello("Ann")
        }
    }
}
