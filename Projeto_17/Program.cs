using System;

namespace Projeto_17
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Parse("2000-02-25 13:05:58");
            DateTime d2 = DateTime.Parse("2000-02-25T13:05:58Z");
            
            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 Utc: " + d1.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 Utc: " + d2.ToUniversalTime());

            Console.WriteLine();

            Console.WriteLine(d2.ToString("yyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyy-MM-ddTHH:mm:ssZ"));

            Console.WriteLine();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Everybody");
            Console.WriteLine("Hello Friends");
        }
    }
}
