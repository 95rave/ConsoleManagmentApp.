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
        public List<Groups>Group { get;  }
        public List <Student>Studentlist { get;  }
        string CreateGroup(string no, Catagories catagory);
        void ShowGroupList();
        void EditGroup(string oldgroupno, string newgroupno);
        void ShowListOfStudentsInTheGroup();
        void ShowAllStudentList();
        void CreateStudent(string fullname, string no, int id);
        void RemoveStudent();
        Groups FindGroups (string no);
    }
}
