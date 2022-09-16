using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Class_program
//{
//    public class Employee2
//    {
//        private string name;
//        private int id;
//        private static int count;
//        private double bs, hra, da, pt, pf, total, netpaid;

//        public Employee2(string name,double bs,double pt)
//        {
//            count++;
//            id= count;
//            this.name = name;
//            this.bs = bs;
//            this.pt= pt;    
                
//        }
//        public static int displaycount()
//        {
//            return count;
//        }
//        public void calculateSalary()
//        {
//            hra = bs * 0.40;
//            da = bs * 0.20;
//            pf = bs * 0.12;
//            total = bs + hra + da;
//            netpaid=total-(pf+pt);
//        }
//        public string displayvalue()
//        {
//            return$"Emp name:{name} Emp id:{id} Total salary:{total} Net paid:{netpaid}";
//        }
    

//    }
//    internal class program
//    {
//        static void Main(String[] args)
//        {
//            Employee2 E1 = new Employee2("abcd", 27000, 200);
//            E1.calculateSalary();
//            Console.WriteLine(E1.displayvalue());

//            Employee2 E2=new Employee2("xxyz",25500,200);
//            E2.calculateSalary();
//            Console.WriteLine(E2.displayvalue());

//            Employee2 E3 = new Employee2("xxyz", 25500, 200);
//            E3.calculateSalary();
//            Console.WriteLine(E3.displayvalue());

//            Console.WriteLine(Employee2.displaycount());

//        }
//    }
//}



