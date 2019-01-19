using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPstart
{
   

    class Player
    {
        int number = 0;
        Random rndComputer = new Random();
        public void Guess()
        {
            number = rndComputer.Next(5);
            Console.WriteLine($"Это число {number}");
        }
    }

    class GuessGame
    {
        Player p1;
        Player p2;
        Player p3;

        public void StartGame()
        {
            p1 = new Player();  // экземляры - игроки
            p2 = new Player();
            p3 = new Player();

            int guessp1 = 0;  // переменные для хранения вариантов чисел, назв игроками
            int guessp2 = 0;
            int guessp3 = 0;

            bool p1isRight = false; // состояния угадал - не угадал
            bool p2isRight = false;
            bool p3isRight = false;

            int targetNumber; // это число назовет комп, его надо угадать
            Random rnd = new Random();
            targetNumber = rnd.Next(5);
            Console.WriteLine("Я, твой комп, загадываю число от 0 до 10 ...");

            while (true)
            {
                Console.WriteLine($"Число, которое надо угадать: {targetNumber}");

                if(guessp1 == targetNumber)
                {
                    p1isRight = true;
                }
                if(guessp2 == targetNumber)
                {
                    p2isRight = true;
                }
                if(guessp3 == targetNumber)
                {
                    p3isRight = true;
                }
                if(p1isRight || p2isRight || p3isRight)
                {
                    Console.WriteLine("У нас есть победитель!!!");
                    Console.WriteLine($"Первый угадал? - {p1isRight}");
                    Console.WriteLine($"Второй угадал? - {p2isRight}");
                    Console.WriteLine($"Третий угадал? - {p3isRight}");
                    Console.WriteLine("Поздравляю победителей!! Конец игры");
                    break;
                }
                else
                {
                    Console.WriteLine("Угадавших нет. Попробуйте еще раз.");
                    break;
                }
            }
            
        }
    }
   
       
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame game = new GuessGame();
            game.StartGame();
            /*Random rnd = new Random();
            int valrandom = rnd.Next(10);
            Console.WriteLine(valrandom);*/
            

            Console.ReadKey();
        }
    }
}
