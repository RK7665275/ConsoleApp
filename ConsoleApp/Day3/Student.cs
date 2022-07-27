using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Day3
{
     class Student
    {
        //data field
        int _RollNo;
        string _Name;   
        int _Age;

        internal void SetStudentDetails(int _RollNo,string _Name,int _Age)
        {
            this._RollNo = _RollNo;
            this._Name = _Name;
            this._Age = _Age;
            Console.WriteLine("Details Saved!!!!");
        } 
       public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Details Are:");
            Console.WriteLine($"Roll No:{_RollNo}\tName:{_Name}\tAge:{_Age}");
        }
                    
        }
    }
