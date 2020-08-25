using System;
using System.Threading;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            START:
            Console.WriteLine("What is your favorite elementary school subject?");
            var subject = Console.ReadLine();
            switch (subject)
            {
                case "Recess":
                    Console.WriteLine("Yeah man, school is for fools!");
                    break;
                case "recess":
                    Console.WriteLine("Yeah man, school is for fools!");
                    break;
                case "nothing":
                    Console.WriteLine("Yeah man, school is for fools!");
                    break;
                case "Nothing":
                    Console.WriteLine("Yeah man, school is for fools!");
                    break;
                default:
                    Console.WriteLine("Well aren't you a nerd? Try again!");
                    goto START;
                    
            }
        }
    }
}
