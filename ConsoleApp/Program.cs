//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppSep
//{

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ///*
//            //Console.WriteLine("Welcome to C#");
//            //Console.WriteLine("this is nextline");
//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Console.WriteLine(i);
//            //}

//            //Console.WriteLine("main ends");*/

//            //using Read() method
//            ///*
//            //int charUnicode;
//            //Console.WriteLine("Enter any character:");
//            //charUnicode= Console.Read();
//            //Console.WriteLine("Char unicode is:"+charUnicode);
//            //*/

//            //int id;
//            //string name;
//            //float salary;
//            //char grade;
//            //Console.WriteLine("Input details:");
//            //Console.WriteLine("Enter ID:");
//            //id = Int32.Parse(Console.ReadLine());//parsing string to int
//            //Console.WriteLine("Enter Name:");
//            //name = Console.ReadLine();//no need to parse
//            //Console.WriteLine("Enter Salary:");
//            //salary = Single.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter Grade:");
//            //grade = Char.Parse(Console.ReadLine());

//            //// Int32.Parse(string);
//            ////Single.Parse(string);
//            ////Char.Parse(string)

//            //Console.WriteLine("Details are:");
//            ///*
//            //Console.Write("ID:"+id);
//            //Console.Write("\tName:" + name);
//            //Console.Write("\tSalary:" + salary);
//            //Console.WriteLine("\tGrade:" + grade);*/

//            //Console.WriteLine("ID:" + id + "\tName:" + name + "\tSalary:" + salary + "\tGrade:" + grade);
//            //Console.WriteLine("ID:{0}\tName:{1}\tSalary:{2}\tGrade:{3}", id, name, salary, grade);
//            //Console.WriteLine($"ID:{id}\tName:{name}\tSalary:{salary}\tGarde:{grade}");//C#6.0 above

//            //Console.WriteLine("PRESS ANY KEY:");
//            //ConsoleKeyInfo ck = Console.ReadKey(true);
//            //Console.WriteLine("*");
//            //Console.WriteLine("\nPressed KeyChar:" + ck.Key);
//            //Console.WriteLine("Pressed Key:" + ck.KeyChar);


//            //Console.Write("ENTER PASSWORD:");
//            //String pwd = "";
//            //ConsoleKeyInfo ck = Console.ReadKey(true);

//            //while (ck.Key != ConsoleKey.Enter)
//            //{
//            //    Console.Write("*");
//            //    pwd = pwd + ck.KeyChar;
//            //    ck = Console.ReadKey(true);

//            //}
//            //Console.WriteLine($"\n Password is:{pwd}");


//            //int x = 20;
//            //Object obj = x;
//            //Console.WriteLine($"value:{obj}\t type:{obj.GetType()}");

//            //int y = (int)obj;
//            //Console.WriteLine($"value:{y}\t type:{y.GetType()}");

//            //float z = (int)obj;
//            //Console.WriteLine($"value:{z}\t type:{z.GetType()}");

//            //var obj1 = x;
//            //int a = obj1;
//            //Console.WriteLine($"value:{obj1}\t type:{obj1.GetType()}");

//            //var obj2 = new StringBuilder("string data");
//            //Console.WriteLine($"value:{obj2}\t type:{obj2.GetType()}");

//            //dynamic d = x;
//            //int b = d;
//            //Console.WriteLine($"value:{d}\t type:{d.GetType()}");

//            int choice = 5;
//            switch (choice)
//            {

//                case 1:
//                    Console.WriteLine("one");
//                    break;
//                case 2:
//                    Console.WriteLine("two");
//                    break;

//                default:
//                    Console.WriteLine("invalid");
//                    break;
//            }
//            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
//            Console.WriteLine("Arry data:");
//            foreach (int item in arr)
//            {
//                Console.WriteLine(item);
//            }


//        }
//    }

//}
