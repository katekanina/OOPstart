using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogTestEncapsulation
{
    class GoodDog
    {
        private int weight;
        public int GetWeight()
        {
            return weight;
        }
        public void SetWeight(int w)
        {
            weight = w;
        }
        public void Bark()
        {
            if(weight > 60)
            {
                Console.WriteLine("Ou-Ou-Ou-Ou-O");
            }
            else if(weight > 20)
            {
                Console.WriteLine(" U-U-U-U-U");
            }
            else if(weight < 1)
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                Console.WriteLine("Uff");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* GoodDog dog1 = new GoodDog();
             dog1.SetWeight(0);
             dog1.Bark();

             GoodDog dog2 = new GoodDog();
             dog2.SetWeight(100);
             dog2.Bark();

             GoodDog dog3 = new GoodDog();
             dog3.SetWeight(12);
             dog3.Bark();

             GoodDog dog4 = new GoodDog();
             dog4.SetWeight(22);
             dog4.Bark();*/

            GoodDog[] dogs = new GoodDog[5];
            dogs[0].SetWeight(12);
            dogs[0].Bark();
            Console.ReadKey();
        }
    }
}
