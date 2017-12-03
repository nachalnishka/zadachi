using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int rand = r.Next(1, 101);
            for(int i=1;i<=100;i++)
            {
                string input = Console.ReadLine();
                int guess = int.Parse(input);

                if (guess == rand)
                {
                    Console.WriteLine("Позна");
                    Console.WriteLine("Опити {0}", i);
                    break;
                }
                else
                {
                    if (rand > guess) Console.WriteLine("Числото е по-голямо");
                    if (rand < guess) Console.WriteLine("Числото е по-малко");
                }
            }
        }
    }
}
