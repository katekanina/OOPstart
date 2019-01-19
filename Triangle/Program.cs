using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTest
{
    class Dog
    {
        public int weight;
        public void Bark()
        {
            if(weight > 60)
            {
                Console.WriteLine("Р-Р-Р гав-гав");
            }
            else if(weight > 20 && weight <= 60)
            {
                Console.WriteLine("тяф-тяф");
            }
            else
            {
                Console.WriteLine("пу-пуф");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.weight = 120;
            dog1.Bark();
            Dog dog2 = new Dog();
            dog2.weight = 12;
            dog2.Bark();
            Dog dog3 = new Dog();
            dog3.weight = 45;
            dog3.Bark();



            Console.ReadKey();
        }
    }
}
