using ConsoleManagmentApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp.Models
{
   class Groups
    {
        public string No;
        public Catagories Catagory;
        public bool IsOnline;
        public int Limit;
        byte _limit;
        List<Groups> GroupList = new List<Groups>();
        public static int count = 100;
        public static int groupcount;


        public List<Student> StudentList = new List<Student>();
        public Groups(Catagories catagory, bool isOnline)
        {

            Catagory = catagory;
            IsOnline = isOnline;
            count++;
            groupcount++;
            Limit = IsOnline ? 2 : 3;

            switch (catagory)
            {
                case Catagories.Programing:
                    No = $"P-" + groupcount;
                    break;
                case Catagories.Desing:
                    No = $"D-" + groupcount;
                    break;
                case Catagories.SystemAdministration:
                    No = $"SA-" + groupcount;
                    break;
                default:
                    break;
            }
            count++;
        }

        public List<Groups>CheckList
        { 
            get=>GroupList;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    GroupList = new List<Groups>(_limit);
                    Console.WriteLine("Online limt is 15 student");

                }
                else if (IsOnline)
                {
                    _limit = 10;
                    GroupList = new List<Groups>(_limit);
                    Console.WriteLine("Online limt is 10 student");
                }
            }
        } 
        
	


        public Groups()
        {

        }

        static Groups()
        {
            count = 0;
            groupcount = 100;
        }

        public void ShowStudent()
        {
           foreach(Student student in StudentList)
            {
                Console.WriteLine(student);
            }
        }
        public override string ToString()
        {
            if (IsOnline==true)
            {
                return $"Group No: {No} Catagory: {Catagory} This Group in online";
            }
            return $"Group No: {No} Catagory: {Catagory} This Group in ofline";
        }
    }
}
