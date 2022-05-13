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
        

        
        public Student(string fullname, string no, int id, bool guaranty)
        {
            FullName = fullname;
            GroupNo = no;
            Id = id;
            Guaranty = guaranty;
        }

    }
}
