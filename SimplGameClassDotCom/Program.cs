using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplGameClassDotCom
{
    class MakeHit // получаем выстрел от пользователя
    {
        public static int ProcessInput()
        {
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("Enter a number:");
            int cell = Int32.Parse(Console.ReadLine());
            return cell;
        }
    }

    class RandomNumberGenerator// получаем случайное число 
    {
        public int GenerateNumber()
        {
            Random random = new Random();
            // Console.WriteLine(random.Next(10));
            return random.Next(10);
        }
    }

    class MakeShips//строим корабль
    {
        public List<int> Create(int rand)
        {
            List<int> ship = new List<int>();
            ship.Add(rand);
            ship.Add(rand + 1);
            ship.Add(rand + 2);
            /*Console.WriteLine(new string('-', 35));
            Console.WriteLine($"A new ship is");
            foreach(int i in ship)
            {
                Console.WriteLine(i);

            }*/
            return ship;
        }
    }

    public class DotCom
    {
        private List<int> locationCells;

        public void SetLocationCells(List<int> loc)
        {
            locationCells = loc;
        }

        public string CheckYourself(int userInput)
        {
            string result = "Missed";
            int index = locationCells.IndexOf(userInput);
            if (index >= 0)
            {
                locationCells.RemoveAt(index); // удаляем элемент по адресу index
                if(locationCells.Count == 0)
                {
                    result = "Killed";
                }
                else
                {
                    result = "Hit";
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            //получаем рандомное число (n)
            RandomNumberGenerator makePositions = new RandomNumberGenerator();
            int n = makePositions.GenerateNumber();

            Random r = new Random();
            int a = r.Next(5);

            Console.WriteLine(new string ('-', 35));
            Console.WriteLine($"New random number is {n}");

            //строим корабль (newShip)
            MakeShips makeShips = new MakeShips();
            List<int> newShip = makeShips.Create(n);
            Console.WriteLine(new string('-', 35));
            Console.WriteLine($"A new ship is");

            foreach (int i in newShip)
            {
                Console.WriteLine(i);
            }

            //делаем выстрел (pos)
            //MakeHit position = new MakeHit();
            int pos = MakeHit.ProcessInput();
            Console.WriteLine(new string('-',35));
            

            //проверяем точность выстрела
            int numOfGuesses = 1;
            bool isAlive = true;

            DotCom dotCom = new DotCom();
            dotCom.SetLocationCells(newShip);
            string result = dotCom.CheckYourself(pos);

            while (isAlive)
            {
                pos = MakeHit.ProcessInput();
                result = dotCom.CheckYourself(pos);
                numOfGuesses++;
                if(result == "Killed")
                {
                    isAlive = false;
                    Console.WriteLine("fin");
                    Console.WriteLine($"Вы потопили корабль! Сделали {numOfGuesses} выстрела(ов)");
                }
            }
            
                      

            Console.ReadKey();



        }
    }
}
