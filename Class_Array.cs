using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Class_program
{
    internal class Class_Array
    {
        //public class course
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public int Fees { get; set; }

        //    public override string ToString()
        //    {
        //        return $"Course details : {Id}  {Name}  {Fees}";
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    course[] Courses =
        //      {
        //        new course{Id=1,Name="Java",Fees=20000},
        //        new course{Id=2,Name="c++",Fees=10400},
        //        new course{Id=3,Name="c#",Fees=20000},
        //        new course{Id=4,Name="Python",Fees=25000},
        //       };
        //    foreach (course c in Courses)
        //    {
        //        Console.WriteLine(c);
        //    }

        //}


        //public class Department
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Location { get; set; }

        //    public override string ToString()
        //    {
        //        return $"Department details : {Id}  {Name}  {Location}";
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Department[] Departments =
        //    {
        //        new Department{Id=1,Name="Chemical",Location="Delhi"},
        //        new Department{Id=2,Name="IT",Location="Banglore"},
        //        new Department{Id=3,Name="Electrical",Location="Mumbai"},
        //        new Department{Id=4,Name="Mechanical",Location="Pune"},
        //    };
        //    foreach (Department de in Departments)
        //    {
        //        Console.WriteLine(de);
        //    }

        //}



        //3)find Max number.............
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[10] { 20, 12, 35, 42, 55, 30, 71, 84, 66, 92 };
        //    int i, max;
        //    //n = 10;
        //    max = arr[0];
        //    for(i = 1; i < arr.Length; i++)
        //    {
        //        if(arr[i] > max)
        //        {
        //            max = arr[i];
        //        }

        //    }
        //    Console.WriteLine("Max number ={0}",max);

        //}



        //4)find Minimum number from array..........
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[10] { 10, 12, 25, 42, 56, 30, 61, 84, 66, 93 };
        //    int i, min;
        //    min = arr[0];
        //    for (i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }

        //    }
        //    Console.WriteLine("Minimum number ={0}", min);

        //}



        //5)Find duplicate numbers in array..........
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[7] { 1, 2, 3, 2, 4, 3, 5 };


        //for (int i = 0; i < arr.Length; i++)
        //{
        //    int count = 0;
        //    for (int j = i; j < arr.Length - 1; j++)
        //    {
        //        if (arr[i] == arr[j])

        //            count = count + 1;
        //    }
        //    Console.WriteLine("\t" + arr[i] + "occurs" + count + " times");

        //}
        //Console.ReadKey();


        //    var d = new Dictionary<int, int>();
        //    foreach (var res in arr)
        //    {
        //        if (d.ContainsKey(res))
        //            d[res]++;
        //        else
        //            d[res] = 1;
        //    }
        //    foreach (var val in d)

        //        Console.WriteLine("{0}occure {1} time", val.Key, val.Value);
        //}



        //6)Remove a given element from an array.......
        //static void Main(string[] args)

        //{
        //    int[] arr = new int[7] { 1, 2, 3, 2, 4, 3, 5 };
        //    //int item;
        //int pos = -1;

        //foreach (var v in arr)
        //{
        //    Console.WriteLine(v);
        //}

        //Console.WriteLine("Enter item to delete");
        //item = int.Parse(Console.ReadLine());
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (item == arr[i])
        //    {
        //        pos = i;
        //        break;
        //    }
        //}
        //if (pos == -1)
        //{
        //    Console.WriteLine("Element not in aaray");
        //}
        //else
        //{
        //    for (int i = pos; i < arr.Length-1; i++)
        //    {
        //        arr[i] = arr[i + 1];
        //    }
        //    Console.WriteLine("Array after deletion:");
        //    for (int i = 0; i < 6; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //    Console.WriteLine();
        //}


        //foreach (var v in arr)
        //{
        //    Console.WriteLine(v);
        //}
        //int indexToRemove = 5;
        //arr = arr.Where((source, index) => index != indexToRemove).ToArray();
        //Console.WriteLine("Array after deletion");

        //foreach (var value in arr)
        //{
        //    Console.WriteLine(value);
        //}






        //7)Find a contiguous subarray whose sum is equal to the given number


        //8)Divide array in two parts and reverse the two parts




        //9)Find maximum number from each row of two dimensional array with dimensions( 3 x 4)
        //public class array
        //{
        //    public static void maxelement(int no_ofrow, int[][] arr)
        //    {
        //        int i = 0;
        //        int max = 0;
        //        int[] result = new int[no_ofrow];
        //        while (i < no_ofrow)
        //        {
        //            for (int j = 0; j < arr.Length; j++)
        //            {
        //                if (arr[i][j] > max)
        //                {
        //                    max = arr[i][j];
        //                }
        //            }
        //            result[i] = max;
        //            max = 0;
        //            i++;
        //        }
        //        printArray(result);
        //    }
        //    private static void printArray(int[] result)
        //    {
        //        for (int i = 0; i < result.Length; i++)
        //        {
        //            Console.WriteLine(result[i]);
        //        }
        //    }
        //    public static void Main(string[] args)
        //    {
        //        int[][] arr = new int[][]
        //        {
        //         new int[]{18,26,31,14},
        //         new int[]{15,62,70,18},
        //         new int[]{93,16,11,12}
        //        };
        //        maxelement(3, arr);
        //    }
        //}




        //10)Find the minimum number from a two dimensional array.

        //static void Main(string[] args)
        //{
        //    const int x = 3, y = 5;
        //    int min;
        //    int[,] arr = new int[x, y]
        //    {
        //        { 18,26,31,14,10},
        //        {15,62,70,18,42 },
        //        {93,16,11,12,36 }
        //    };
        //    min= arr[0,0];

        //    for(int i=0;i<x;i++)
        //    {
        //        for(int j=0;j<y;j++)
        //        {
        //            if(arr[i,j]<min)
        //            {
        //                min=arr[i,j];
        //            }
        //        }
        //    }
        //    Console.WriteLine("Array elements");
        //    for(int i=0;i<x;i++)
        //    {
        //        for(int j=0;j<y;j++)
        //        {
        //            Console.WriteLine(arr[i,j]);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Minimun number:"+min);
        //    Console.ReadLine();
        //}



    }

}