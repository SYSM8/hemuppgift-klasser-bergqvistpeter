using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder {  get; set; }
        public double Balance { get; set; }

        //Lägg till Konstruktor
        public BankAccount(string konto, string kontoinnehavare, double saldo) 
        { 
            AccountNumber = konto;
            AccountHolder = kontoinnehavare;
            Balance = saldo; 
        }
        //Lägg till Metoder

        public double Deposit(double addBalance) 
        {
        return Balance + addBalance;
        }

        public double Withdraw(double withdrawBalance) 
        {


            if (Balance - withdrawBalance >= 0)
            {
                return Balance - withdrawBalance;
            }
            else
            {
                Console.WriteLine($"Du försöker ta ut {withdrawBalance} men har bara {Balance} på ditt konto");
            }  
            return Balance;
        }

        public void DisplayBalance() 
        
        { 
            Console.WriteLine($"Ditt saldo är: {Balance}");
        }

        //Lycka till! :)
    }
}
