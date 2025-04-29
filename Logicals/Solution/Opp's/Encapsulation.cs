using Logicals.Opp_s;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.Opp_s
{
    internal class Encapsulation
    {
        private int balance = 1000;
        public int Balance
        {
            set 
            {
                if (value > 0)
                { 
                    balance += value; 
                }
                else
                {
                    Console.WriteLine($"You are trying to set accout balance is = {value} \nYou can't sent Account balance less then zero");
                }
            }

            get
            {
                return balance;
            }            
        }

        [Test]
        public void Encapsulation1() 
        {
         Encapsulation account = new Encapsulation();

            account.Balance = -1;
            Console.WriteLine($"Your Account Balance is {account.Balance}");
        }
    }

    public class Account
    {
        private int balance;

        public void SetAccountBalance(int value)
        {
            balance += value;
        }

        public int GetAccountBalance()
        {
            return balance;
        }

        [Test]
        public void Encapsulation2()
        {
            Account account = new Account();

            account.SetAccountBalance(2000);
            Console.WriteLine($"Your Account Balance is {account.GetAccountBalance()}");
        }
    }
}


