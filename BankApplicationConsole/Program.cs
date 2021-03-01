using System;
using System.Threading;

namespace BankApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Account newAccount = new Account();
            newAccount.Deposit(20);
            Console.WriteLine(newAccount.Withdraw(2));
            var ret = Console.ReadLine();
            Account myAccount = new Account(); // new account
            PersonInfo info = new PersonInfo(); // new personal info
            Console.WriteLine("Hello Please Enter your Your First Name: (print your first Name please ......");// user user input for name
            string fName = Console.ReadLine();
            info.FirstName = fName;
            Console.WriteLine("Hello Please Enter your Your Last Name: (print your last Name please ......");// user user input for name
            string lName = Console.ReadLine();
            info.LastName = lName;
            Console.WriteLine("Hello Please Enter your Your Address: (print your Address please ......");// user user input for name
            string address = Console.ReadLine();
            info.StreetAddress = address;
            Console.WriteLine("Hello Please Enter your Your Address2: (print your Address2 please ......");// user user input for name
            string address2 = Console.ReadLine();
            info.Address2 = address2;
            Console.WriteLine("Hello Please Enter your Your City: (print your City please ......");// user user input for name
            string city = Console.ReadLine();
            info.City = city;
            Console.WriteLine("Hello Please Enter your Your State: (print your state please ......");// user user input for name
            string st = Console.ReadLine();
            info.State = st;
            Console.WriteLine("Hello Please Enter your Your Zip Code: (print your zip code please ......");// user user input for name
            int zip = Int32.Parse(Console.ReadLine());
            info.Zip = zip;
            Console.WriteLine("Hello Please Enter your Your Phone Numbere: (print your Phone Number please ......");// user user input for name
            string phone = Console.ReadLine();
            info.NumberFormatted = phone;
            Console.WriteLine("Your account Balance is :  ......");
            Thread.Sleep(2000);
            Console.WriteLine(newAccount.CheckBalance());
            Console.WriteLine("Enjoy your $100 rewad.");
            Console.WriteLine("This is your Personal Info: ......");
            Thread.Sleep(2000);
            Console.WriteLine(info.PrintAllInfo(fName, lName, address, address2, city, st, zip, phone));
        }


    }
}
