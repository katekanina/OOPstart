using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Car
    {
        public void StartEngine()
        {
            IsEngineRunning = true;
            Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }

        public void Drive(int distance)
        {
            if (IsEngineRunning)
            {
                Console.WriteLine("Driving " + distance + " km");
            }
            else
            {
                Console.WriteLine("Start the egine first");
            }
        } 
        
        private bool IsEngineRunning = false;
    }

    class SimpleDotComTestDrive
    {

        static void Main(string[] args)
        {
            Car mycar = new Car();

            mycar.StartEngine();

            mycar.Drive(100);

            mycar.StopEngine();
        }
    }
}
