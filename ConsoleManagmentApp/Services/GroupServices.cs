using ConsoleManagmentApp.Interface;
using ConsoleManagmentApp.Models;
using System;
using System.Collections.Generic;


namespace ConsoleManagmentApp.Enum
{
    class GroupServices : IGroupServices
    {
        List<System.Text.RegularExpressions.Group> _groups = new List<System.Text.RegularExpressions.Group>();
        public List<System.Text.RegularExpressions.Group> Groups { get =>_groups; }

        public string CreateGroup(string no, Catagories catagory)
        {
            if (string.IsNullOrEmpty(no)||string.IsNullOrWhiteSpace(no))
            {
                return "Enter the correct group number";
            }
            Groups group = new Groups(no, catagory);
            if ()
            {

            }
        }

        public void CreateStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent()
        {
            throw new NotImplementedException();
        }

        public void ShowAllStudentList()
        {
            throw new NotImplementedException();
        }

        public void ShowGroupList()
        {
            throw new NotImplementedException();
        }

        public void ShowListOfStudentsInTheGroup()
        {
            throw new NotImplementedException();
        }
    }

}
