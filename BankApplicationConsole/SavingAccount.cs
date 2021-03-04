using System;
namespace BankApplicationConsole
{
    public class SavingAccount : IAccount
    {
        // IAccount
        public string AccountType { get; set; }
        public int Pin { get;  set ; }
        public double Amount { get; set; }
        public double Balance { get; set; }
        // IPersonInfo
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }

        //SavingAccount Constructor

        public SavingAccount()
        {
            AccountType = "Saving";
            Balance = 100;
        }

        //IAccount Methods
        public double CheckBalance()
        {
            return Balance;
        }

        public double CreateAccount(int pin)
        {
            return pin;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

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

        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }
        // IPersonInfo Methods
        public string PrintAllInfo(string firstName, string lastName, string streetAddy, string address2, string city, string state, int zip, string _phoneNum)
        {
            return ($"First Name: {firstName} \n" +
                 $"Last Name: {lastName} \n" +
                 $"Street Address: {streetAddy} \n" +
                 $"Address 2: {address2} \n" +
                 $"City: {city} \n" +
                 $"State: {state} \n" +
                 $"Zip : {zip} \n" +
                 $"Phone Number : {_phoneNum} \n");
        }
    }
}
