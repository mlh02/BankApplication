using System;
namespace BankApplicationConsole
{
    public interface IAccount : IPersonInfo
    {
        public string AccountType { get; set; }
        public int Pin { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }

        public bool PinValidator(int pin)
        {
             if (pin == Pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CheckBalance();

        public double CreateAccount(int pin);

        public double Withdraw(double amount);

        public double Deposit(double amount);
        

    }
}
