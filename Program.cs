﻿ using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            
            string name = Console.ReadLine();

            Console.WriteLine("Your name is  {0}" , name);
        }
    }
}
