using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int z = 1;

            for (int i = 0; i < n; i++)
            {
                x = y;
                y = z;
                z = x + y;
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
