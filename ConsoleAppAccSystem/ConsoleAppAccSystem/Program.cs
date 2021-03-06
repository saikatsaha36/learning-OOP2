using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAccSystem
{
    class Program : accounts
    {
        static void Main(string[] args)
        {
            int num, n;
            accounts bank = new accounts();

            do
            {
                Console.Write("Developers Bank\n Dhaka");
                Console.Write("\n\t Main Menu");
                Console.Write("\n\t01. New Account");
                Console.Write("\n\t02. Deposit Ammount");
                Console.Write("\n\t03. Withdraw Ammount");
                Console.Write("\n\t04. Balance Transaction");
                Console.Write("\n\t05. Account List");
                Console.Write("\n\t06. Account Modify");
                Console.Write("\n\t07. Exit");
                Console.Write("\n\tSelect Your Option (1-7)");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                
        }
    }
}

