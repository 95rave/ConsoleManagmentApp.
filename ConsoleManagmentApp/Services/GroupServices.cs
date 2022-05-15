using ConsoleManagmentApp.Interface;
using ConsoleManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleManagmentApp.Enum
{
    class GroupServices : IGroupServices
    {
        List<Groups> GroupList = new List<Groups>();
       
        List<Student> StudentList = new List<Student>();

        public List<Groups> Group { get => GroupList; }

        public string CreateGroup(string no, Catagories catagory )
        {
            if (string.IsNullOrEmpty(no) || string.IsNullOrWhiteSpace(no))
            {
                return "Enter the correct group number";
            }
            Groups group = new Groups(no, catagory);
            if (Groups.groupcount >= 0)
            {
                Groups.groupcount++;
                GroupList.Add(group);
                return $" {group.No} is succesfully";

            }
            foreach (Groups groups in GroupList)
            {
                if (!string.IsNullOrEmpty(no) || string.IsNullOrWhiteSpace(no))
                {
                    GroupList.Add(group);
                    return $" {group.No} is succesfully";
                }
            }
            return "Group can't created";
        }

       

        public void CreateStudent(string fullname, string no, int id,bool guaranty)
        {
            Student student = new Student(fullname,no,id,guaranty);
            if (string.IsNullOrEmpty(fullname)||string.IsNullOrWhiteSpace(fullname))
            {
                Console.WriteLine("Enter the student's name correctly");
            }
            else
            {
                Console.WriteLine($"{student.FullName()}");
                StudentList.Add(student);
            }
            
            
        }

        public void CreateStudent(string fullname, string no, int id)
        {
            throw new NotImplementedException();
        }

        public void EditGroup(string oldgroupno, string newgroupno)
        {
            if (FindGroups(newgroupno)==null)
            {
                Groups group = FindGroups(oldgroupno);
                if (group != null)
                {
                    group.No = newgroupno.ToUpper().Trim();
                    Console.WriteLine($"{group.No} is succesfully edited");
                }
                else
                {
                    Console.WriteLine($"There is no group => {oldgroupno.ToUpper()}");
                } 
            }
            
        }
        public Groups FindGroups(string no)
        {
            foreach (Groups group in Group)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
                return null;
            }

        }
        public void ShowAllStudentList()
        {
            if (Student.Count > 0)
            {
                foreach (Student student in StudentList)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("There is no students");
            }
        }

        public void ShowGroupList()
        {
            if (Groups.count>0)
            {
                foreach (Groups Grouplist in Group)
                {
                    Console.WriteLine(Grouplist);
                }
            }
            else
            {
                Console.WriteLine("There is no group");
            }
        }

        public void ShowListOfStudentsInTheGroup()
        {
            foreach (Student student in StudentList)
            {
                Console.WriteLine(student);
            }
        }
        public void RemoveStudent()
        {
            throw new NotImplementedException();
        }

    }



}
