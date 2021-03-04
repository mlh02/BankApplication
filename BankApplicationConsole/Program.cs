using System;
using System.Linq;
using System.Threading;

namespace BankApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Bank Of Monty, What kind of account do you want to create? \n" +
                "1 - Saving Account \n" +
                "2 - Checking Account \n" +
                "3 - Business Account \n");
            string userAccount = Console.ReadLine();

            //Choose the correct type of phone to create through the factory method that implements the ICallable interface
            IAccount phone = AccountFactory.GetAccount(userAccount);

            //FisstName
            Console.WriteLine("Hello Please Enter your Your First Name");// user user input for name
            string fName = Console.ReadLine();
            phone.FirstName = fName;
            //Last Name
            Console.WriteLine("Enter your Your Last Name");// user user input for name
            string lName = Console.ReadLine();
            phone.LastName = lName;
            //Address
            Console.WriteLine("Enter Your Address");// user user input for name
            string address = Console.ReadLine();
            phone.StreetAddress = address;
            //Address 2
            Console.WriteLine("Enter your Your Address2");// user user input for name
            string address2 = Console.ReadLine();
            phone.Address2 = address2;
            //City
            Console.WriteLine("Enter your Your City");// user user input for name
            string city = Console.ReadLine();
            phone.City = city;
            //State
            Console.WriteLine("Enter your Your State");// user user input for name
            string st = Console.ReadLine();
            phone.State = st;
            //Zip
            Console.WriteLine("Enter your Your Zip Code");// user user input for name
            int zip = Int32.Parse(Console.ReadLine());
            phone.Zip = zip;
            //phonenumber
            Console.WriteLine("Enter your Your Phone Number");// user user input for name
            string phon = Console.ReadLine();
            phone.PhoneNumber = phon;

            //pin
            Console.WriteLine("Enter your Your Pin Number");// user user input for name
            int pin = Int32.Parse(Console.ReadLine());
            phone.Pin = pin;

            Console.WriteLine("Your account Balance is :  ......");
            Thread.Sleep(2000);
            Console.WriteLine(phone.CheckBalance());

            Console.WriteLine("Enjoy your $100 reward.");
            Console.WriteLine("This is your Personal Info: ......");
            Thread.Sleep(2000);
            Console.WriteLine("**************************************");
            Console.WriteLine(phone.PrintAllInfo(fName, lName, address, address2, city, st, zip, phon));
            Console.WriteLine($"Account Type: {phone.AccountType}");
            Console.WriteLine("**************************************");
            int finish = -1;
            for (int i = 0; i != finish; i++)
            {
                Console.WriteLine($"Hello {phone.FirstName}, Welcome to Bank, What Would You Like To Do \n" +
                   "1 - Withdraw \n" +
                   "2 - Deposit \n" +
                   "3 - Check Balance \n" +
                   "4 -  Exit \n");
                int actionResponse = Int32.Parse(Console.ReadLine());

                if (actionResponse == 1)
                {
                    Console.WriteLine("Withdraw Amount");
                    double withdrawAmount = Double.Parse(Console.ReadLine());
                    phone.Withdraw(withdrawAmount);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Balance: $" + phone.CheckBalance());
                    Console.WriteLine("--------------------------");

                }
                if (actionResponse == 2)
                {
                    Console.WriteLine("Deposit Amount");
                    int depositAmount = Int32.Parse(Console.ReadLine());
                    phone.Deposit(depositAmount);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Balance: $" + phone.CheckBalance());
                    Console.WriteLine("--------------------------");


                }
                if (actionResponse == 3)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Balance: $" + phone.CheckBalance());
                    Console.WriteLine("--------------------------");

                }
                if (actionResponse == 4)
                {
                    break;
                }


            }
        }

    }
}

