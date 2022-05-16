using ConsoleManagmentApp.Interface;
using ConsoleManagmentApp.Models;
using System;
using System.Collections.Generic;


namespace ConsoleManagmentApp.Enum
{
    class GroupServices : IGroupServices
    {
        List<Groups> GroupList = new List<Groups>();
       
        List<Student> StudentList = new List<Student>();
        private string no;

        public List<Groups> Groups { get => GroupList; }

        public List<Student> Studentlist { get => Studentlist; }

        public void CreateGroup(Catagories catagory, bool isOnline)
        {
            Groups group = new Groups(catagory, isOnline);
            GroupList.Add(group);
            Console.WriteLine(group);
        }
        public void ShowGroupList()
        {

            if (Models.Groups.count > 0)
            {
                foreach (Groups Grouplist in Groups)
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
                foreach (Groups groups in Groups)
                {
                    foreach (Student student in StudentList)
                    {
                        Console.WriteLine($"Full Name: {student.FullName}  Group No: {student.GroupNo}  Point:{student.CheckPoint} Student Id: {Student.Id}");
                    }
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
        public void CreateStudent(string fullName, string groupno,byte checkPoint)
        {
            if (Groups.Count > 0)
            {
                Student student = new Student( fullName, groupno, checkPoint);
  
                if (string.IsNullOrEmpty(student.FullName) || string.IsNullOrWhiteSpace(student.FullName))
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
                    Console.WriteLine($"Full Name: {fullName}  Group No: {groupno}  Point:{checkPoint} Student Id: {Student.Id}");
                }

            }
            else
            {
                Console.WriteLine("Failed to add student to group. Because this group does not exist.");
            }
        }
        public void RemoveStudent(int id,  string groupno)
        {

            Groups group = FindGroups(groupno);
            if (group==null)
            {
                Console.WriteLine("Group can not found");
            }
            if (group.StudentList==null)
            {
                Console.WriteLine("Student can not found");
            }
            if (Student.Id==id)
            {
                foreach (var item in group.StudentList)
                {
                    group.StudentList.Remove(item);
                }
            }
            Console.WriteLine("Student deleted.");
        }
        public Groups FindGroups(string no)
        {
            foreach (Groups group in Groups)
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
