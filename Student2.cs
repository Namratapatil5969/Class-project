using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Class_program
//{
//    public class Student2
//    {
//        private int roll_no;
//        private string name;
//        private double per;

//        public int Roll_no
//        {
//            get { return roll_no; }
//            set { roll_no = value; }
//        }
//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }
//        public double Percentage
//        {
//            get { return per; }
//            set { per = value; }
//        }
//    }
//    internal class program
//    {
//        static void Main(string[] args)
//        {
//            //property initializer syntax
//            Student2 s1 = new Student2();
//            s1.Roll_no = 1;
//            s1.Name = "xyz";
//            s1.Percentage = 75;

//            Console.WriteLine($"Roll no: {s1.Roll_no}  Name :{s1.Name}  Percentage :{s1.Percentage}");


//            //object initializer syntax
//            Student2 s2 = new Student2 {Roll_no=10, Name="abc",Percentage=78.60};
//            Console.WriteLine($"Roll no: {s2.Roll_no}  Name :{s2.Name}  Percentage: {s2.Percentage}");
//        }
//    }
//}



//     // Home work-Auto implemented property
namespace class_program

    {
    public class student2
    {
        public int roll_no { get; set; }
        public int sub1 { get; set; }
        public int sub2 { get; set; }
        public int total { get; set; }
        public string name { get; set; }
        public double per { get; set; }
        

        public void Percentage()
        {
            total = sub1 + sub2;
            per = total / 2;
        }


    }
    internal class program
    {
        static void Main(string[] args)
        {
            student2 s1 = new student2 { roll_no = 10,name="xyz",sub1=70,sub2=75 };
            s1.Percentage();
            Console.WriteLine($"Roll no :{s1.roll_no} Name :{s1.name} Percentage :{s1.per}");

            student2 s2 = new student2 { roll_no = 15, name = "abc", sub1=60,sub2=68 };
            s2.Percentage();
            Console.WriteLine($"Roll no :{s2.roll_no} Name :{s2.name} Percentage :{s2.per}");

            student2 s3 = new student2 { roll_no = 18, name = "xyz", per = 85 };
            Console.WriteLine($"Roll no :{s3.roll_no} Name :{s3.name} Percentage :{s3.per}");
        }
            
    }

}