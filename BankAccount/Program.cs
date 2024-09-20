namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            Employee employee = new Employee("Peter", "Bergqvist");
            employee.Salary = 3000;

            employee.GetAnnualSalary();
            employee.GiveRaise(10);

        }
    }
}
