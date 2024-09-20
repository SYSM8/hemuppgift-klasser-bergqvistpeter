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
        public string Balance { get; set; }

        public BankAccount(string konto, string kontoinnehavare, string saldo) 
        { 
            AccountNumber = konto;
            AccountHolder = kontoinnehavare;
            Balance = saldo; 
        }


        //Lägg till Konstruktor

        //Lägg till Metoder

        //Lycka till! :)
    }
}
