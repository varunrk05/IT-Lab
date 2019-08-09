using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppThree
{
    class Program
    {
        public delegate string delFunc();
        class TrafficSignal
        {
            public static string Yellow()
            {
                return ("Slow down!");
            }

            public static string Green()
            {
                return ("It's a go!");
            }

            public static string Red()
            {
                return ("Please stop!");
            }
        }

        static void Main(string[] args)
        {
            delFunc greenFunc, yellowFunc, redFunc;
            greenFunc = TrafficSignal.Green;
            yellowFunc = TrafficSignal.Yellow;
            redFunc = TrafficSignal.Red;

            Console.WriteLine("Green means: {0}\nYellow means: {1}\nRed means: {2}", greenFunc(), yellowFunc(), redFunc());
            Console.Read();
        }
    }
}
