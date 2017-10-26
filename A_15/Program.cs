using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź liczbę.");
            int a = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (a != 0)
            {
                suma += a % 10;
                a = a / 10;
            }
            Console.WriteLine("Suma cyfr: " + suma);
            Console.ReadKey();
        }
    }
}
