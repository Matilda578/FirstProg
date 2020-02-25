using System;

namespace FirstProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your Firstname?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your Last Name?");
            string lastname = Console.ReadLine();

            string fullname = firstname + " " + lastname;

            Console.WriteLine(fullname); 
        }
    }
}
