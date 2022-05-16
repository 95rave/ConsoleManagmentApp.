using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp
{
    class Student
    {
        public string Name;
        public string Surname;
        public string GroupNo;
        public bool Type;
        public static int Count;
        static int Id;
        byte _point;
        bool _guaranty;
        List<Student> StudentList = new List<Student>();


        
        public Student(string name,string surname, string no)
        {
            Name = name;
            Surname = surname;
            GroupNo = no;
            Type = false;
        }
        
        public string FullName()
        {
            return $"Name: {Name} Surname: {Surname} Group No: {GroupNo}";
        }

        public byte CheckPoint 
        { get => _point;

            set
            {
                if (value>80)
                {
                    Console.WriteLine(("Guaranteed student"));
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
            return $"Student: \n {FullName()}\n Group No: {GroupNo}\n Is Guaranty: {CheckPoint} {_guaranty}";
        }


    }
}
