using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class NewConstants
    {
        private double pi = 3.14D;
        private double e = 3.71D;
        public double Pi //свойство только для записи
        {
            set
            {
                pi = value;
            }
        }
        public double E //свойство только для чтения
        {
            get
            {
                return e;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewConstants constants = new NewConstants();
            Console.WriteLine($"e = {constants.E}");
            constants.Pi = 3.1415444D;
            
            Console.ReadKey();
        }
    }
}
