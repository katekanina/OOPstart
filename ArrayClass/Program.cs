using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numHouses = { 22, 24, 18 };
            int[] numRevers = numHouses;
            //Array numObj = numHouses as Array;
            for(int i = 0; i < numHouses.Length; i++)
                Console.WriteLine(numHouses[i]);

            Console.WriteLine(new string ('-', 12));

            int ind = Array.IndexOf(numHouses,22);
            Console.WriteLine($"index of a number 22 is {ind}");

            Console.WriteLine(new string('-', 12));

            int ind2 = Array.IndexOf(numHouses, 18);
            Console.WriteLine($"index of a number 18 is {ind2}");

            Console.WriteLine(new string('-', 12));

            Array.Find(numHouses =>)

            Console.WriteLine(new string('-', 12));
            Array.Sort(numRevers);
            for (int i = 0; i < numRevers.Length; i++ )
                Console.WriteLine(numRevers[i]);

            Console.ReadKey();
        }
    }
}
