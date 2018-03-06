using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS_Recursion_11.Service;

namespace ADS_Recursion_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = NumberGenerator.Random(10, -10, 10);

            foreach (var i in list)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
