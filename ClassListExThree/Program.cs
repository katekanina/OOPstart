using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassListExThree
{
    class Program
    {
        class Book
        {
            public int Price { set; get; }
            public string Name { set; get; }
        } 

        class Ship
        {
           // public int[] Cell();

            public int[] Cell1 { set; get; }
            public int Cell2 { set; get; }
            public int Cell3 { set; get; }

            public void MakeShip(List<Ship>)
            {
                cw

            }

        }
        static void Main(string[] args)
        {
            /*List<Book> books = new List<Book>();
            books.Add(new Book() { Name = "TeleBook", Price = 24 });
            books.Add(new Book() { Name = "OOO", Price = 120 });
            books.Add(new Book() { Name = "My Fool", Price = 450 });
            books.Add(new Book() { Name = "Tipi", Price = 1 });

            foreach(Book i in books)
            Console.WriteLine($"название: {i.Name}, цена: {i.Price}");
            Console.WriteLine(new string ('-', 35));
            Console.ReadKey();*/


            List<Ship> ships = new List<Ship>();
            Ship a = new Ship();
            Ship b = new Ship();
            ships.Add(b);
            ships.Add(a);
            int n = ships.IndexOf(a);
            int nn = ships.IndexOf(b);
            Console.WriteLine(n);
            Console.WriteLine(nn);
            Console.ReadKey();

        }
    }
}
