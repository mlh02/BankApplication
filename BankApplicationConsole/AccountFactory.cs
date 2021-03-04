using System;
namespace BankApplicationConsole
{
    public static class AccountFactory
    {
        public static IAccount GetAccount(string accountType)
        {
            switch (accountType.ToLower())
            {
                case "1":
                    return new SavingAccount();
                case "2":
                    return new BusinessAccount();
                case "3":
                    return new CheckingAccount();
                default:
                    return new CheckingAccount();
            }
        }
    }
}
