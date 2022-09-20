using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_program
{

    internal class testArray
    {
        //static void Main(string[] args)
        //{
        //    int[] numbers = new int[5] { 10, 20, 30, 40, 50 };

        //    string[] names = { "Tushar", "Rohan", "Suraj", "Raj" };

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine($"numbers {i} = {numbers[i]}");
        //    }

        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        Console.WriteLine($"names {i} = {names[i]}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    int[] numbers = new int[5];

        //    string[] names = { "Tushar", "Rohan", "Suraj", "Raj" };
        //    Console.WriteLine("Enter 5 elements");
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        numbers[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("----------------------");
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine($"numbers {i} = {numbers[i]}");
        //    }
        //}

        static void Main(string[] args)
        {
            string[] names = new string[5];
            Console.WriteLine("Enter 5 names");
            for(int i=0; i < names.Length; i++)
            {
                names[i] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("-----------------");
            for(int  i=0; i < names.Length; i++)
            {
                Console.WriteLine($"names{i}={names[i]}");
            }
        }




    }
}
