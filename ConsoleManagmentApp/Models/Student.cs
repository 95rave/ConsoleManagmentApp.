using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public int Id;
        public bool Guaranty;
        List<Student> StudentList = new List<Student>();
        

        
        public Student(string fullname, string no, int id, bool guaranty)
        {
            FullName = fullname;
            GroupNo = no;
            Id = id;
            Guaranty = guaranty;
        }
        public void StudentInfo()
        {
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"Fullname: {student.FullName} \n Group No: {student.GroupNo} \n ID: {student.Id} \n Guaranty:{student.Guaranty} ");
            }
        }

    }
}
