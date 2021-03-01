using System;
using Xunit;

namespace BankApplicationTest
{
    public class DepositTest
    {

        [Theory]
        [InlineData(899, 899)]

        public void CreateAccount(int pin, double expected)
        {
            //Arrange
            BankApplicationConsole.Account sut = new BankApplicationConsole.Account();

            //Act

            double actual = sut.CreateAccount(pin);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(500)]

        public void CheckBalance(double expected)
        {
            //Arrange
            BankApplicationConsole.Account sut = new BankApplicationConsole.Account();

            //Act

            double actual = sut.CheckBalance();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(300, 800)]
        [InlineData(500, 1000)]

        public void Deposit(double amount, double expected)
        {
            //Arrange
            BankApplicationConsole.Account sut = new BankApplicationConsole.Account();

            //Act

            double actual = sut.Deposit(amount);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(300, 200)]
        [InlineData(500, 0)]


        public void Withdraw(double amount, double expected)
        {
            //Arrange
            BankApplicationConsole.Account sut = new BankApplicationConsole.Account();

            //Act

            double actual = sut.Withdraw(amount);
            //Assert
            Assert.Equal(expected, actual);
        }
       

    }
   
}
