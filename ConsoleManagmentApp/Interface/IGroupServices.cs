using ConsoleManagmentApp.Enum;
using ConsoleManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleManagmentApp.Interface
{
    interface IGroupServices
    {
        public List<Groups>Groups { get;  }
        public List <Student>Studentlist { get;  }
        void CreateGroup(Catagories catagory, bool isOnline);
        void ShowGroupList();
        void EditGroup(string oldgroupno, string newgroupno);
        void ShowAllStudentList();
        void ShowListOfStudentsInTheGroup();
        void CreateStudent(string fullName,  string groupno,byte checkPoint );
        void RemoveStudent(int id , string groupno);
        
    }
}
