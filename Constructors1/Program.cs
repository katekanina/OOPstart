using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors1
{
    class Program
    {
        static void Main(string[] args)
        {
            Points pointСoordinates = new Points();
            Console.WriteLine($"Координаты по умолчанию: {pointСoordinates.X}, {pointСoordinates.Y}");
            Console.WriteLine(new string('-', 30)) ;
            
            Points pointUser = new Points(30, 12);
            Console.WriteLine($"Координаты пользователя: {pointUser.X}, {pointUser.Y}");
            Console.ReadKey();

        }
    }
}
