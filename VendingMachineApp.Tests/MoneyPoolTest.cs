using System;
using Xunit;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;

namespace VendingMachineApp.Tests
{
    public class MoneyPoolTest
    {


        // check if the data entered is a numeric value or not
        [Fact]
        public void ValidateShould_ReturnNumericalValue()
        {
            var sut = new MoneyPool();
            var acutal = sut.Validate("1");
            Assert.Equal(1,acutal);
        }


        // check if ResetBalance makes balance 0
        [Fact]
        public void ResetBalanceShould_SetBalanceToZero()
        {
            var sut = new MoneyPool();
            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney("50");
            sut.ResetBalance();
            Assert.Equal(0, sut.GetBalance()) ;
        }


        // check if GetBalance return the  balance 20
        [Fact]
        public void GetBalanceShould_GetRightBalance()
        {
            var sut = new MoneyPool();
            var vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney("20");
            Assert.Equal(20, sut.GetBalance());
        }
    }
    
}
