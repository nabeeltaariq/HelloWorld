 using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int num= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num + num2;

            Console.WriteLine("Addition is {0}", sum);


            //Console.WriteLine("Enter your Firstname:");
            //string fname = Console.ReadLine();

            //Console.WriteLine("Enter your Lastname:");
            //string lname = Console.ReadLine();


            //Console.WriteLine("Your name is  {0} {1}" , fname, lname);
        }
    }
}
