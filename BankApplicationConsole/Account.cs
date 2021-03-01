using System;
namespace BankApplicationConsole
{
    public class Account
    {

        public int Pin { get; set; }
        public string Amount { get; set; }
        private double _balance = 500;

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
        public double CheckBalance()
        {
            return _balance;
        }
        public double CreateAccount(int pin)
        {
            return pin;
        }
        public double Withdraw(double amount)
        {
            return _balance -= amount;
           
        }
        public double Deposit(double amount)
        {
            
            return _balance += amount;
        }

    }
}
