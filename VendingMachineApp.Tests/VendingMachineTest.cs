using System;
using Xunit;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;

namespace VendingMachineApp.Tests
{
    public class VendingMachineTest
    {
        // testing Purchase method
        [Fact]
        public void PurchaseShould_PurchaseProduct()
        {
            var moneyPool = new MoneyPool();
            var vendingMachine = new VendingMachine(); // adding 15kr and Purchase for 15kr
            vendingMachine.InsertMoney("15");           // so Balance will be zero
            vendingMachine.Purchase(1);
            Assert.Equal(0, moneyPool.GetBalance());
        }

        // testing InsertMoney method
        [Fact]
        public void InsertMoneyShould_IncreaseBalance()
        {
            var moneyPool = new MoneyPool();
            var sut = new VendingMachine();
            sut.InsertMoney("50");
            Assert.Equal(50, moneyPool.GetBalance());
            sut.InsertMoney("100");
            Assert.Equal(150, moneyPool.GetBalance());


        }
        //Testing EndTransaction method
        [Fact]
        public void EndTransactionShould_EndPurchase()
        {
            //EndTransaction return refund and reset balance to zero
            var moneyPool = new MoneyPool();
            var sut = new VendingMachine();
            sut.InsertMoney("50");
            Assert.Equal(50, moneyPool.GetBalance());
            sut.EndTransaction(moneyPool);  // it has a Beep sound and wait time Thread.Sleep(3000); 
            Assert.Equal(0, moneyPool.GetBalance());
        }
    }
}
