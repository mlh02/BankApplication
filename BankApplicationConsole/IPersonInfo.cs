using System;
using System.Text.RegularExpressions;

namespace BankApplicationConsole
{
    public interface IPersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }


        public string PrintAllInfo(string firstName, string lastName, string streetAddy, string address2, string city, string state, int zip, string _phoneNum);
       
    }
}
