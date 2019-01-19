using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors1
{
    class Points
    {
        private int x, y;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }

        public Points()
        {
            Console.WriteLine("Конструктор по умочанию");
        }
        public Points(int a, int b)
        {
            Console.WriteLine("Конструктор пользовательский");
            this.x = a;
            this.y = b;
        }
    }
}
