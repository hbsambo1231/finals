using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCALCULATOR_APP

namespace CCALCULATOR_APP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(functions.Add(4, 10));
            Console.WriteLine(functions.subtract10, 4));
            Console.WriteLine(functions.multiply(4, 10));
            Console.WriteLine(functions.divide(10, 2));

            Console.ReadKey();
        }
    }
}
