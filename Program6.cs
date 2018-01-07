using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var f = File.Open("storage.txt", FileMode.Open))
                {
                    byte[] buf = new byte[5];
                    DynamicArray contents = new DynamicArray();

                    int read;
                    do
                    {
                        read = f.Read(buf, 0, buf.Length);

                        contents.AddRange(buf, read);
                    }
                    while (read != 0);

                    var text = Encoding.UTF8.GetString(contents.ToArray());

                    Console.WriteLine(text);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Write("файлът не е намерен: ");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Неочаквана грешка" + e.Message);
            }
            Console.ReadLine();
        }
    }
}
