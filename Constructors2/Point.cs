using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors2
{
    class Point
    {
        private int x, y;
        private string name;
        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }
        public Point(int a, int b)
        {
            Console.WriteLine("Конструктор с двумя пользовательскими параметрами");
            this.x = a;
            this.y = b;
        }
        public Point(string nameUser):this(100, 100)
        {
        }
    }
}
