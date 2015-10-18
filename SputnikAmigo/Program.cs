using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SputnikAmigo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Installing Amigo...");
            Thread.Sleep(500);

            for (int i = 0; i < 100; i += 5)
            {
                Console.WriteLine(i + "%");
                Thread.Sleep(50);

            }
            Console.WriteLine("Install success!");

            Thread.Sleep(500);

            Console.WriteLine("Installing Sputnik...");
            Thread.Sleep(500);
            while(true)
            { }

            for (int i = 0; i < 100; i += 5)
            {
                Console.WriteLine(i + "%");
                Thread.Sleep(50);

            }
            Console.WriteLine("Install success!");

            Console.ReadKey();
        }
    }
}
