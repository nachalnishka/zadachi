using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //въвеждат се x и y и се определя в кой квадрант са

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > 0 & y > 0) Console.WriteLine("{0} и {1} са в първи квадрант", x, y);
            if (x>0 & y<0) Console.WriteLine("{0} и {1} са във втори квадрант", x, y);
            if(x<0 & y<0) Console.WriteLine("{0} и {1} са в трети квадрант", x, y);
            if(x<0 & y>0) Console.WriteLine("{0} и {1} са в четвърти квадрант", x, y);
            Console.ReadLine();
        }
    }
}
