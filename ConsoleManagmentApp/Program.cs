using ConsoleManagmentApp.service;
using System;

namespace ConsoleManagmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte selection;
            Console.WriteLine("Welcome to the course.");
            do
            {

                
                Console.WriteLine("1.Create new Group.");
                Console.WriteLine("2.Show Group List.");
                Console.WriteLine("3.Edit Group.");
                Console.WriteLine("4.Show all Student List.");
                Console.WriteLine("5.Show List of Students in the Group.");
                Console.WriteLine("6.Create Student.");
                Console.WriteLine("7.Remove Student.");
                Console.WriteLine("0.Exit.");

                bool result = byte.TryParse(Console.ReadLine(), out selection);
                Console.Clear();

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            MenuGroupServices.CreateGroupMenu();
                            break;
                        case 2:
                            MenuGroupServices.ShowGroupListMenu();
                            break;
                        case 3:
                            MenuGroupServices.EditGroupmenu();
                            break;
                        case 4:
                            MenuGroupServices.ShowAllStudentListMenu();
                            break;
                        case 5:
                            MenuGroupServices.ShowListOfStudentsInTheGroupMenu();
                            break;
                        case 6:
                            MenuGroupServices.CreateStudentMenu();
                            break;
                        case 7:
                            MenuGroupServices.RemoveStudentMenu();
                            break;
                        default:
                            break;
                    }
                }

            } while (selection!=0);
        }
    }
}
