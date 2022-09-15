using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//Create a class Student with rollno, name , 3 subjects marks . calculate total marks &
//percentage using method & display it by using parameter constructor


//namespace Class_program
//{

//
//
//   public class Student1
//    {
//        string name;
//        int roll_no, sub_1, sub_2, sub_3;
//        double total, per;


//        public Student1(string name, int roll_no, int sub_1, int sub_2, int sub_3)/*double per*/
//        {
//            this.name = name;
//            this.roll_no = roll_no;
//            this.sub_1 = sub_1;
//            this.sub_2 = sub_2;
//            this.sub_3 = sub_3;
//            //this.per = per;

//        }
//        public void Percentage()
//        {
//            total = sub_1 + sub_2 + sub_3;
//            per = total / 3;

//        }

//        public string displayvalue()
//        {
//            return $"Name is {name}\nRoll number is {roll_no}" +
//                $"\nSub1 :{sub_1}\nSub2 :{sub_2}\nSub3 :{sub_3}\nPercentage :{per}";


//        }


//        internal class program
//        {
//            public static void Main(string[] args)
//            {
//                Student1 s1 = new Student1("Namrata", 25, 70, 85, 80);
//                s1.Percentage();
//                Console.WriteLine(s1.displayvalue());
//            }
//        }
//    }
//}