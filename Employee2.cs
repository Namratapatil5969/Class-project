using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace Class_program
//{
//    public class Employee2
//    {
//        protected string name;
//        protected int id;
//        protected static int count;
//        protected double bs, hra, da, pt, pf, total, netpaid;

//        public Employee2(string name, double bs, double pt)
//        {
//            count++;
//            id = count;
//            this.name = name;
//            this.bs = bs;
//            this.pt = pt;

//        }
//        public static int displaycount()
//        {
//            return count;
//        }
//        public virtual void calculateSalary()
//        {
//            hra = bs * 0.40;
//            da = bs * 0.20;
//            pf = bs * 0.12;
//            total = bs + hra + da;
//            netpaid = total - (pf + pt);
//        }
//        public string displayvalue()
//        {
//            return $" Emp id:{id}  Emp name:{name} Total salary:{total} Net paid:{netpaid}";
//        }
//    }
//        public class Manager : Employee2
//        {
//            private double ta;

//             public Manager(string name, double bs, double pt,double ta):base(name,bs,pt) 
//        {
//            this.ta = ta;
//        }
//        public override void calculateSalary()
//        {
//            hra = bs * 0.40;
//            da = bs * 0.20;
//            pf = bs * 0.12;
//            total = bs + hra + da+ta;
//            netpaid = total - (pf + pt);
//        }
//            public override string ToString()
//            {
//                return $"Manager Id {id} Manager name {name} , total salary {total} & Net paid {netpaid}";
//            }
//        }
//    public class salesmanager:Employee2
//    {
//        private double comm, bonus;
//        public salesmanager(string name, double bs, double pt, double comm,double bonus) : base(name, bs, pt)
//        {
//            this.comm = comm;
//            this.bonus = bonus;

//        }
//        public override void calculateSalary()
//        {
//            hra = bs * 0.40;
//            da = bs * 0.20;
//            pf = bs * 0.12;
//            total = bs + hra + da + comm+bonus;
//            netpaid = total - (pf + pt);
//        }
//        public override string ToString()
//        {
//            return $"Sales Manager Id {id} Sales Manager name {name} , total salary {total} & Net paid {netpaid}";
//        }

//    }



    
//    internal class program
//    {
//        static void Main(String[] args)
//        {
//            salesmanager s1 = new salesmanager("abcd", 55000, 200, 1000, 5000);
//            s1.calculateSalary();
//            Console.WriteLine(s1);
//            Console.WriteLine();


//            //Manager m1 = new Manager("managar1", 45000, 250, 5000);
//            //m1.calculateSalary();
//            //Console.WriteLine(m1);
//            //Console.WriteLine();

//            //Employee2 E1 = new Employee2("abcd", 27000, 200);
//            //E1.calculateSalary();
//            //Console.WriteLine(E1.displayvalue());
//            //Console.WriteLine();


//            //Employee2 e1 = new Manager("managar2", 43000, 250, 5000);
//            //// association of method with object does at run time
//            //e1.calculateSalary(); // runtime polymorphism
//            //Console.WriteLine(e1);
//            //Console.WriteLine();


//            //Employee2 E2 = new Employee2("xxyz", 25500, 200);
//            //E2.calculateSalary();
//            //Console.WriteLine(E2.displayvalue());

//            //Employee2 E3 = new Employee2("xxyz", 25500, 200);
//            //E3.calculateSalary();
//            //Console.WriteLine(E3.displayvalue());

//            //Console.WriteLine(Employee2.displaycount());

//        }
//    }
//}



