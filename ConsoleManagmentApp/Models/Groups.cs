using ConsoleManagmentApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp.Models
{
    class Group
    {
        public string No;
        public byte  Limit;
        public Catagories Catagory;
        public bool IsOnline;
        List<Group> GroupList = new List<Group>();
        public static int count = 100;
        public static int groupcount;

        public Group(string no, Catagories catagory)
        {
            No = no;
            Catagory = catagory;
            IsOnline = false;

        }
        public List<Group>CheckList
        { 
            get=>GroupList;
            set
            {
                if (!IsOnline)
                {
                    Limit = 15;
                    GroupList = new List<Group>(Limit);

                }
                else if (IsOnline)
                {
                    Limit = 10;
                    GroupList = new List<Group>(Limit);
                }
            }
        }
      
        
        
        
       
    }
}
