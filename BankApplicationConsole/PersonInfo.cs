using System;
using System.Text.RegularExpressions;

namespace BankApplicationConsole
{
    public class PersonInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        private string _phoneNumber;
        public string NumberFormatted
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
        }
       
        public string PrintAllInfo(string firstName, string lastName, string streetAddy, string address2, string city, string state, int zip, string _phoneNum )
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
