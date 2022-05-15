using ConsoleManagmentApp.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleManagmentApp.Models
{
    class Groups
    {
        public string No;
        public byte  Limit;
        public Catagories Catagory;
        public bool IsOnline;
        List<Groups> GroupList = new List<Groups>();
        public static int count = 100;
        public static int groupcount;

        public Groups(string no, Catagories catagory, bool isOnline)
        {
            No = no;
            Catagory = catagory;
            IsOnline = false;

        }

        public Groups(string no, Catagories catagory)
        {
            No = no;
            Catagory = catagory;
        }

        public List<Groups>CheckList
        { 
            get=>GroupList;
            set
            {
                if (!IsOnline)
                {
                    Limit = 15;
                    GroupList = new List<Groups>(Limit);

                }
                else if (IsOnline)
                {
                    Limit = 10;
                    GroupList = new List<Groups>(Limit);
                }
            }
        }      
    }
}
