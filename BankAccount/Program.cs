using System.Security.Cryptography.X509Certificates;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Peter", "Bergqvist");
            //employee.Salary = 3000;

            //employee.GetAnnualSalary();
            //employee.GiveRaise(10);
            //Instansiera bankAccount klassen och testa den

            BankAccount B1 = new BankAccount("123456789", "Peter", 1000); // Skapat ett nytt konto



            Console.WriteLine("Skriv in ditt kontonummer:"); // inloggning på kontonummret
            string input = Console.ReadLine();

            if (input == B1.AccountNumber)  // om kontot stämmer Så loggar vi in till menyn

            {
                bool keepGoing = true;
                while (keepGoing) // while loop för att hålla kontot öppet till man loggar ut
                {
                    Console.WriteLine("Välj ett av följande alternativ: \n 1. Ta ut pengar \n 2. Sätta in pengar \n 3. Kolla Saldo \n 4. Logga ut");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice) // switch för att komma åt de olika menyraderna.

                    {
                        case 1:  // alternativ 1 anropar withdraw från classen BankAccount
                            Console.WriteLine("Välj hur mycket du vill ta ut:");
                            int withdrawAccount = Convert.ToInt32(Console.ReadLine());
                            B1.Withdraw(withdrawAccount);
                            break;
                        case 2:  // Alternativ 2 anropar Deposit från classen BankAccount
                            Console.WriteLine("Välj hur mycket du vill sätta in:");
                            int depositAccount = Convert.ToInt32(Console.ReadLine());
                            B1.Deposit(depositAccount);
                            break;
                        case 3:  // Alternativ 3 anropar DisplayBalance från classen BankAccount
                            B1.DisplayBalance();
                            break;
                        case 4:
                            Console.WriteLine("Du kommer nu att loggas ut"); // avslutar loopen
                            keepGoing = false;
                            break;
                        default:
                            Console.WriteLine("Du har valt ett felaktikt alternativ!"); // om alternativ ligger utanför 1-4
                            break;
                    }
                    }
                }
            else  // om man skriver fel kontonummer
                {
                    Console.WriteLine("Du har skrivit fel kontonummer"); 
                }

            }
        }
    }

