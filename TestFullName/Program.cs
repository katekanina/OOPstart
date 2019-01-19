using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFullName
{
    class Myclass
    {
        //делаем массив упорядоченных четных натуральных чисел
        public  int[] PairValuesArray(int n)
        {
            int countOfElements = n / 2 + 1;
            int[] resultArray = new int[countOfElements];
            for (int i = 0; i < countOfElements; i++)
            {
                
                    resultArray[i] = i * 2;
                    Console.WriteLine($" {i} -й элемент {resultArray[i]}");

                

            }
            return resultArray;
        }

        //функция получает n агументов и вычисляет сумму этих аргументов
        public int SumArguments(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
                

            }
            Console.WriteLine(result);
            return result;
        }



    }
    class Program
    {
         
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.SumArguments(1,3,3,5);
            myclass.SumArguments();
            myclass.SumArguments(22, 18);
            Console.WriteLine(new string('-',10));
            //myclass.PairValuesArray(15);
            Console.ReadKey();
        }
    }
}
