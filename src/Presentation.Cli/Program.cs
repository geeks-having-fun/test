using System;
using my_lib;

namespace Presentation.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var x = new Class1(Console.WriteLine);
            x.Log();
        }
    }
}
