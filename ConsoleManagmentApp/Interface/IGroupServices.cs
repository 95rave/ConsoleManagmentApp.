using ConsoleManagmentApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleManagmentApp.Interface
{
    interface IGroupServices
    {
        public List<Group>Groups { get;  }
        string CreateGroup(string no, Catagories catagory);
        void ShowGroupList();
        void EditGroup();
        void ShowListOfStudentsInTheGroup();
        void ShowAllStudentList();
        void CreateStudent();
        void RemoveStudent();




    }
}
