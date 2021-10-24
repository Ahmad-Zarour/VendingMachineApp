using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Data;
using VendingMachineApp.Modle;

namespace VendingMachineApp
{
    interface IVending
    {
        public void Purchase(int productId);  //Purchase, to buy a product.
        public void ShowAll(List<Product> listOfProducts);  //ShowAll, show all products.
        public bool InsertMoney(string amount);  //InsertMoney, add money to the pool.
        public void EndTransaction(MoneyPool balance);  //EndTransaction, returns money left in appropriate amount of change.
    }
}
