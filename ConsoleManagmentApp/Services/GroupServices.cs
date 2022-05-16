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
        private string no;

        public List<Groups> Group { get => GroupList; }

        public List<Student> Studentlist { get => Studentlist; }

        public void CreateGroup(Catagories catagory, bool isOnline)
        {
            Groups group = new Groups(catagory, isOnline);
            GroupList.Add(group);
            Console.WriteLine(group);
        }
        public void ShowGroupList()
        {
            if (Groups.count > 0)
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

       

        public void ShowListOfStudentsInTheGroup()
        {

            foreach (Student student in StudentList)
            {
                Console.WriteLine(student);

            }
        }
        public void CreateStudent(string name, string surname,string groupno)
        {
            if (Group.Count > 0)
            {
                Student student = new Student(name, surname, groupno); 
  
                if (string.IsNullOrEmpty(student.FullName()) || string.IsNullOrWhiteSpace(student.FullName()))
                {
                    Console.WriteLine("Enter the correct student Fullname");
                }
                else
                {
                    Groups group = GetGroup(groupno);
                    if (group == null)
                    {
                        Console.WriteLine("Group not found");
                        return;
                    }
                    if (group.StudentList.Count >= group.Limit)
                    {
                        Console.WriteLine("Group not found");
                        return;
                    }
                    Console.WriteLine($"Name: {name} Surname: {surname} Group No: {groupno}");
                }

            }
            else
            {
                Console.WriteLine("Failed to add student to group. Because this group does not exist.");
            }
        }
        public void RemoveStudent(string name, string surname, string groupno)
        {
            foreach (Student student in StudentList )
            {
                StudentList.Remove(student);
                break;
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
            }
            return null;
        }
        Groups GetGroup(string groupno)
        {
            foreach (Groups group in GroupList)
            {
                if (group.No==groupno)
                {
                    return group;
                }
            }
            return null;
        }
    }



}
