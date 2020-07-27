using System;

namespace PasscodeP
{
    class Program
    {
        static void Main(string[] args)
        {
            checkPassCode();
        }

        static void checkPassCode()
        {
            //git project pulled by Samy
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
