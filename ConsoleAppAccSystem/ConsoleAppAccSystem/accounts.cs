﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccSystem
{
    class accounts
    {
        //private int acno;

        //public int useracno
        //{
        //    get { return acno; }
        //    set { acno = value; }
        //}
        private static int serialNo = 0;
        private string acno;

        internal virtual string ID
        {
            get { return this.acno; }
            set { this.acno = "P" + value; }
        }

           
            protected String name;
            internal int deposit;
            protected internal Char userType;

            private void create_account()
            {
                Console.Write("\nEnter the Account No : ");
                acno = (++serialNo).ToString();
                //Console.WriteLine("ID: {0}", this.acno = (++serialNo).Tostring());
                //useracno = int.Parse(Console.ReadLine());
                Console.Write("Enter The Name of The account Holder : ");
                name = Console.ReadLine();
                Console.Write("\nEnter Type of The account (C/S) : ");
                userType = char.Parse(Console.ReadLine());
                Console.Write("Enter the ammount(500 for savings and 1000 for current) : ");
                deposit = int.Parse(Console.ReadLine());
                Console.Write("ACCOUNT CREATED..");

            }
            public void createAcount()
            {
                create_account();
            }
           

            public void show_Account()
            {
                //this.acno = (++serialNo).ToString();
                Console.WriteLine("ID: {0}", this.acno);
                //Console.Write("\nAccount No :{0}", acno)
                Console.Write("\nAccount Holder Name : {0}", name);
                Console.Write("\nType of Account : {0}", userType);
                Console.Write("\n Balance Ammount : {0}", deposit);
            }
            public void showAccount()
            {
                show_Account();
            }


            internal void modifyAccount()
            {
                //this.acno = (++serialNo).ToString();
                Console.Write("\nAccount No :"); 
                //acno = (++serialNo).Tostring();
                Console.Write("Account holder Name :");
                name = Console.ReadLine();
                Console.Write("Type of Account :");
                userType = char.Parse(Console.ReadLine());
                Console.Write("Balance Of Ammount : ");
                deposit = int.Parse(Console.ReadLine());
            }
           



    }
}
