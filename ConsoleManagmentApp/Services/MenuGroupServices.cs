using ConsoleManagmentApp.Enum;
using ConsoleManagmentApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp.service
{
   static class MenuGroupServices
    {
        public static GroupServices groupservices=new GroupServices();
        public static void CreateGroupMenu()
        {
            Groups groups = new Groups();
           
            Console.WriteLine("Enter the catagory");

            object catagory;

            foreach (var item in System.Enum.GetValues(typeof (Catagories)))
            {
                Console.WriteLine($"{ (int)item}.{ item}" );
            }
           
            
            bool result = System.Enum.TryParse(typeof(Catagories), Console.ReadLine(), out catagory);
            Console.WriteLine("Join classes:");
            Console.WriteLine("1.0nline \n2.Ofline");


            byte selection = Convert.ToByte(Console.ReadLine());

            if (selection==1)
            {
                groups.IsOnline = true;
            }
            else if (selection == 2)
            {
                groups.IsOnline = false;
            }

            if (result)
            {
              groupservices.CreateGroup((Catagories)catagory, groups.IsOnline);
            }
        }
        public static void ShowGroupListMenu()
        {
            groupservices.ShowGroupList();
        }
        public static void EditGroupmenu()
        {
            Console.WriteLine("Enter the Group no");
            string oldgroupno = Console.ReadLine();
            Console.WriteLine("Enter the Group no");
            string newgroupno = Console.ReadLine();
            groupservices.EditGroup(oldgroupno, newgroupno);
        }
        public static void ShowAllStudentListMenu()
        {
            Console.WriteLine("Enter the Group no");
            string groupno = Console.ReadLine();
            groupservices.ShowAllStudentList();
        }
        public static void ShowListOfStudentsInTheGroupMenu()
        {
            groupservices.ShowListOfStudentsInTheGroup();
        }
        public static void CreateStudentMenu()
        {
            Console.WriteLine("Enter the Student Name and Surname");
            string fullName = Console.ReadLine();
            Console.WriteLine("Enter the Group number");
            string groupno = Console.ReadLine();
            Console.WriteLine("Enter your entry score");
            byte point = Convert.ToByte(Console.ReadLine());
            groupservices.CreateStudent(fullName,groupno,point);
        }
        public static void RemoveStudentMenu()
        {
            Console.WriteLine("Enter the Student Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Group number");
            string groupno = Console.ReadLine();
            groupservices.RemoveStudent(id, groupno);
        }
    }
}
