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

        //static void Main(string[] args)
        //{
        //    string[] names = new string[5];
        //    Console.WriteLine("Enter 5 names");
        //    for(int i=0; i < names.Length; i++)
        //    {
        //        names[i] = Convert.ToString(Console.ReadLine());
        //    }
        //    Console.WriteLine("-----------------");
        //    for(int  i=0; i < names.Length; i++)
        //    {
        //        Console.WriteLine($"names{i}={names[i]}");
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    string[] names = new string[5]{"Reena","Arya","Riya","Disha","Vedha" };
        //    string[] nums = new string[3];

        //    Console.WriteLine("Original array");

        //    foreach (string i in names)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine("sorted array");
        //    //Array.Sort(names);
        //     //Array.Reverse(names);
        //    Array.Clear(names, 2, 2);
        //    //Array.Copy(names, 1, nums,0, 3);
        //    // Array.Copy(names, nums, names.Length);
        //    //int index = Array.IndexOf(names, "Disha");
        //    //Console.WriteLine($"index of Disha is {index}");
        //    foreach (string i in names)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        static void Main(string[] args)
        {
            // 3 - row
            // 4- col
            int[,] arr = new int[3, 4]
            {
               { 1,2,3,4},
               {5,6,7,8 },
               {9,10,11,12 }
            };

            for (int i = 0; i < arr.GetLength(0); i++)  // GetLength(0) -> specifies row size
            {
                for (int j = 0; j < arr.GetLength(1); j++)  // GetLength(1)-> specifies col size
                {
                    Console.Write($"arr[{i},{j}]= {arr[i, j]}  ");
                }
                Console.WriteLine();
            }
        }







    }
}
