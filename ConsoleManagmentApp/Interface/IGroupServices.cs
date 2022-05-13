using ConsoleManagmentApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp.Interface
{
    interface IGroupServices
    {
        public List<Student> Students { get; set; }
        string CreateGroup();
        void ShowGroupList();
        void EditGroup();
        void ShowListOfStudentsInTheGroup();
        void ShowAllStudentList();
        void CreateStudent();
        void RemoveStudent();




    }
}
