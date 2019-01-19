using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassListExOne
{
    public class Book
    {
        public string BookName { set; get; }
        public int Price { set; get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // создаем List<Book>
            List<Book> myList = new List<Book>();

            //добавляем элементы
            myList.Add(new Book() { BookName = "Властелин колец", Price = 200 });
            myList.Add(new Book() { BookName = "Малыш и карлсон", Price = 150 });
            myList.Add(new Book() { BookName = "Теория вероятностей", Price = 300 });
            myList.Add(new Book() { BookName = "Поверь в себя", Price = 680 });
            // в листе myList 4 элемента { "Властелин колец", 200 }, { "Малыш и карлсон", 150 }, { "Теория вероятностей", 300 }, {"Поверь в себя", 680 }

            // вставляем элемент перед индексом 1
            // сначала создаем этотэлемент
            Book book = new Book() { BookName = "Волшебник", Price = 900 };
            myList.Insert(1, book); // вставляем
            // теперь в листе myList такой список { "Властелин колец", 200 }, { "Волшебник", 900}, { "Малыш и карлсон", 150 }, и т.д.

            // удаляем элемент по индексу 2, т.е. удалится { "Малыш и карлсон", 150 }
            myList.RemoveAt(2);
            //лист myList теперь такой { "Властелин колец", 200 }, { "Волшебник", 900}, { "Теория вероятностей", 300 }, {"Поверь в себя", 680 }

            // удалим элемент { "Волшебник", 900}
            myList.Remove(book);
            // лист myList теперь такой { "Властелин колец", 200 }, { "Теория вероятностей", 300 }, {"Поверь в себя", 680 }

            for(int i = 0; i < myList.Count; i++)
            {
                Book item = myList[i];
                Console.WriteLine($"Назавание : {item.BookName}, Цена : {item.Price}");
            }
            Console.ReadKey();
        }
    }
}
