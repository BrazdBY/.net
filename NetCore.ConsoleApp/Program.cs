using System;

namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {
            string username;
            if (args.Length > 0)
            {
                username = args[0];
            }
            else
            {
                Console.Write("Please enter your name: ");
                username = Console.ReadLine();
            }
            var HelloMessage = SharedLibrary.SayHello.GetHello(username);
            Console.WriteLine($"{HelloMessage}");
        }
    }
}
