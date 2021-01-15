using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
              
            int age = 0;
            Console.WriteLine("enter your age ");
            age = Convert.ToInt16(Console.ReadLine());
            int birth = 2021 - age;
            Console.WriteLine(" birth =  " +birth);
        }
    }
}
