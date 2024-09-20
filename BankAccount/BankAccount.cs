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

        public double Deposit(double addBalance) //Metod för att sätta in pengar
        {
            double newBalance = addBalance + Balance;
            Balance = newBalance;
            Console.WriteLine($"Du har satt in {addBalance} och ditt nya Saldo är {Balance}. ");
            return Balance ;
        }

        public double Withdraw(double withdrawBalance) // metod för att ta ut pengar och kolla om där är tillräckligt
        {


            if (Balance - withdrawBalance >= 0) 
            {
                
                double newBalance = Balance - withdrawBalance;
                Balance = newBalance;
                Console.WriteLine($"Du har tagit ut {withdrawBalance} och ditt nya Saldo är {Balance}. ");
                return Balance;
            
            }
            else
            {
                Console.WriteLine($"Du försöker ta ut {withdrawBalance} men har bara {Balance} på ditt konto");
            }  
            return Balance;
        }

        public void DisplayBalance() // metod för att visa balans.
        
        { 
            Console.WriteLine($"Ditt saldo är: {Balance}");
        }

        //Lycka till! :)
    }
}
