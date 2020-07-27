using System;

namespace PasscodeP
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            while (code != "secret")
            {
                Console.WriteLine("What is the passcode?");
                code = Console.ReadLine();

                if (code != "secret")
                    Console.WriteLine("You are not authenticated");
            }
            Console.WriteLine("You are authenticated");
        }
    }
}
