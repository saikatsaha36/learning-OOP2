using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccSystem
{
    class Account
    {     
        //private int acno;

        //public int useracno
        //{
        //    get { return acno; }
        //    set { acno = value; }
        //}
        private static int serialNo = 0;
        private string acno;
        //private string address;

        internal virtual string ID
        {
            get { return this.acno; }
            set { this.acno = "P" + value; }
        }
     
        //internal string Address
        //{
        //    get { return this.address; }
        //    set { this.address = value; }
        //}

           
            protected String name;
            internal int deposit;
            protected internal Char userType;
            internal string address;

            private void create_account()
            {
                Console.Write("\nEnter the Account No : ");
                acno = (++serialNo).ToString();
                //Console.WriteLine("ID: {0}", this.acno = (++serialNo).Tostring());
                //useracno = int.Parse(Console.ReadLine());
                Console.Write("Enter The Name of The account Holder : ");
                name = Console.ReadLine();
                Console.Write("Enter The account Holder Address : ");
                address = Console.ReadLine();

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
                Console.Write("\nAccount Holder Address :{0}", address);
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
            public void modify_account()
            {
                modifyAccount();
            }
            public void accountdep()
            {
                int x;
                Console.Write("Enter the ammount You want Deposit:");
                x = int.Parse(Console.ReadLine());
                deposit += x;
            }
            public void accountdraw()
            {
                int x;
                Console.Write("Enter the ammount You want withdraw:");
                x = int.Parse(Console.ReadLine());
                deposit -= x;
            }
            public void account_report()
            {
                Console.Write("AccNo ::{0} \nName::{1} \nType::{2} \nDeposit:{3}\n", acno, name, userType, deposit);
            }
            public string retacno()
            {
                return acno;
            }
            public int retdeposit()
            {
                return deposit;
            }
            public char rettype()
            {
                return userType;
            }



    }
}
