using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[0]) {
                case "-client":
                    break;
                case "-server":
                    var server = new Server();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
