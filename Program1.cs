using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("demand0=");
            decimal Demand0 = decimal.Parse(Console.ReadLine());
            Console.Write("demandunit=");
            decimal Demandunit = decimal.Parse(Console.ReadLine());
            Console.Write("costinitial=");
            decimal Costinitial = decimal.Parse(Console.ReadLine());
            Console.Write("costunit=");
            decimal Costunit = decimal.Parse(Console.ReadLine());

            decimal a = -Demandunit;
            decimal b = Costunit * Demandunit + Demand0;
            decimal c = -Costunit * Demand0 - Costinitial;

            decimal x = -b / (2 * a);
            decimal y = a * x * x + b * x + c;
            Console.Write("x={0}", x);
            Console.Write("y={0}", y);
            Console.ReadLine();

        }
    }
}
