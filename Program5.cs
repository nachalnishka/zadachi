using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Брой дискове: ");
            int n = int.Parse(Console.ReadLine());

            char a = 'A';
            char b = 'B';
            char c = 'C';

            solveTowers(n, a, b, c);

        }

        private static void solveTowers(int n, char a, char b, char c)

        {
            if (n > 0)
            {
                solveTowers(n - 1, a, c, b);
                Console.WriteLine("Премести " + a + ' ' + b);
                solveTowers(n - 1, b, a, c);
            }
            Console.ReadLine();
        }

    }


    }
