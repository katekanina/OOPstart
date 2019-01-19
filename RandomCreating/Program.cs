using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCreating
{
    public class RandomGenerator
    {
        // generate a random number between two numbers
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // generate a random string with a given size !!!!! почитать про классы String / StringBuilder !!!!
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder strBuild = new StringBuilder();
            Random random = new Random();
            char ch;
            for(int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                strBuild.Append(ch);
            }
            if (lowerCase)
            {
                return strBuild.ToString().ToLower();
            }
            return strBuild.ToString();
            
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator generator = new RandomGenerator();
            int rand = generator.RandomNumber(5, 100);
            Console.WriteLine($"Random number between 5 and 100 is {rand}");
            Console.ReadKey();

        }
    }
}
