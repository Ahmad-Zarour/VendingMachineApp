using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachineApp.Data;

namespace VendingMachineApp.Modle
{
    public class VendingMachine : IVending
    {
        public MoneyPool moneyPool = new MoneyPool();
        public ProductRepo productRepo = new ProductRepo();

        

        //Purchase, to buy a product.
        public void Purchase(int productId) 
        {
            var product = productRepo.RetrieveByProductId(productId);
            if(product != null )
            {
                if (product.Price <= moneyPool.Balance)
                {
                    Console.WriteLine("Successful purchase, Pickup your order.");
                    moneyPool.Balance -= product.Price;
                    productRepo.Use(product);
                }
                else
                    Console.WriteLine($"Sorry! you don't have enugh money to buy {product.ProductName}, please Add More Money to your balance.\n" +
                                      $"Price Of Product: [{product.Price}] kr , Your Blanace Is : [{moneyPool.Balance}] kr");
            }
            else
                Console.WriteLine("Product code not exsist!, Check the available products.");
        }

        //ShowAll, show all products.
        public void ShowAll(List<Product> listOfProducts)
        {
            Console.WriteLine("Here are what you can buy from our vending machine.\n");
            foreach (var item in listOfProducts)
            {
                Console.WriteLine($"Code [{item.ProductId}] <-|->  {item.ProductName}  <-->  Price: [{item.Price}]kr");
            }
        }


        //InsertMoney, add money to the pool.

        public bool InsertMoney(string input)
        {
            int amount = moneyPool.Validate(input);
            bool acceptedunit = false;
            foreach (int unit in MoneyDenomination.AcceptedDenominations)
            {
                if (unit == amount)
                {
                    moneyPool.Balance += amount;
                    acceptedunit = true;
                    Console.Write($"Accepted money {amount}kr. Your current balance:");
                    moneyPool.ShowBalance();
                    Console.WriteLine();
                    return true;
                }
            }
            if (!acceptedunit) Console.WriteLine("Money amount you entered is Rejected!");
            return false;
        }

        /// Returns money left in appropriate amount of change.
        public void EndTransaction(MoneyPool balance) 
        {
            Console.Beep();
            Console.WriteLine("Thank you for Useing our vending machine");
            if (balance.GetBalance() != 0)
            {
                Console.WriteLine("Your refund will be initiated shortly");
                System.Threading.Thread.Sleep(3000);
                Console.Write("Please take the refund: ");
                moneyPool.ShowBalance();
            }
            Console.WriteLine("Good bye");
            moneyPool.ResetBalance();
        }
    }
}
