using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


//Create a class Rectangle &accept the value of L & B from constructor & calculate perimeter of rectangle

//namespace Class_program
//{
//    public class Rectangle
//    {
//        int length, breadth;
//        double peri;
//        public Rectangle(int length, int breadth)
//        {
//            this.length = length;
//            this.breadth = breadth;

//        }
//        public void Perimeter()
//        {
//            peri = 2 * (length + breadth);
//        }

//        public string displayvalue()
//        {
//            return $"Length :{length}\nBreadth :{breadth}\nPerimeter is:{peri}";
//        }

//    }
//}

//namespace Class_program
//{

//    internal class program
//    {
//        public static void Main(string[] args)
//        {
//            Rectangle R1 = new Rectangle(10, 20);
//            R1.Perimeter();
//            Console.WriteLine(R1.displayvalue());
//        }
//    }
//}  



namespace Class_program
{
    public class Rectangle
    {
        int length, breadth;
        double peri;

        public void Assignvalue()
        {
            length = 8;
            breadth = 10;
        }

        public void Perimeter()
        {
            peri = 2 * (length + breadth);
        }
        public string displayvalue()
        {
            return $"Length:{length}\nBreadth:{breadth}\nPerimeter is:{peri}";
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle();
            R1.Assignvalue();
            R1.Perimeter();
            Console.WriteLine(R1.displayvalue());
        }
    }
}
