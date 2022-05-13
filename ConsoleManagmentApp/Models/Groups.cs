using ConsoleManagmentApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp.Models
{
    class Groups
    {
        public string No;
        public byte  Limit;
        public Catagories Catagory;
        public bool IsOnline;
        List<Student> StudentList = new List<Student>();

        public Groups(string no, Catagories catagory)
        {
            No = no;
            Catagory = catagory;
            IsOnline = false;

        }
        public List<Student>Students 
        {
            get => StudentList;

            set
            {
                if (!IsOnline)
                {
                    Limit = 15;
                    StudentList = new List<Student>(Limit);
                }
                else
                {
                    Limit = 10;
                    StudentList = new List<Student>(Limit);
                }
            }
        
        
        }
        public void Student()
        {
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"Fullname: {student.FullName} \n Group No: {student.GroupNo} \n ID: {student.Id} \n Guaranty:{student.Guaranty} " );
            }
        }
    }
}
