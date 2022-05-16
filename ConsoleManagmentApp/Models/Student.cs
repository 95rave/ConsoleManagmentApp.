using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public static int CountId;
        public static int Count;
        public static int Id;
        byte _point;
        bool _guaranty;
        List<Student> StudentList = new List<Student>();


        
        public Student(string fullName,string no, byte checkPoint)
        {
            FullName = fullName;
            GroupNo = no;
            Id = ++Count;
            CheckPoint = checkPoint;
        }
        

        public byte CheckPoint 
        { get => _point;

            set
            {
                if (value>80)
                {
                    Console.WriteLine("Guaranteed student");
                    _point = value;
                    _guaranty = true;
                }
                else if (value < 80)
                {
                    Console.WriteLine("Not a guaranteed student");
                    _point = value;
                    _guaranty = false;
                }
            }
        }
        static Student()
        {
            Count = default;
        }
        public override string ToString()
        {
            return $"Student: \n {FullName}\n Group No: {GroupNo}\n Is Guaranty: {CheckPoint} {_guaranty} \nOnline: {CheckPoint} \nStudent Id:{Id}";
        }
      

    }
}
