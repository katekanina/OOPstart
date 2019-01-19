using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islands
{
    
    class ProgramIslandsTests
    {
        static void Main(string[] args)
        {
            string [] islands = new string[4];
            islands[0] = "Бермуды";
            islands[1] = "Фиджи";
            islands[2] = "Косумель";
            islands[3] = "Азорские острова";



            /*такое решение дается в книге

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            int y = 0;
            int refer;
            while(y < 4)
            {
                refer = index[y];
                Console.WriteLine($"острова: {islands[refer]}");
                y++;
            }*/

            // этот цикл делает то же самое
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine($"острова: {islands[i]}");
            }


            Console.ReadKey();
        }
    }
}
