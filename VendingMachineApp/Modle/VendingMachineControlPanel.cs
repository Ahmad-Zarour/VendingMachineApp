using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Data;
using VendingMachineApp.Modle;


namespace VendingMachineApp.Modle
{
    public class VendingMachineControlPanel
    {
        readonly MoneyPool moneyPool = new MoneyPool();
        readonly VendingMachine vendingMachine = new VendingMachine();

        // Method to show the products and the current balance 
        public void MainScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n      _______________________________________________________ ");
            Console.WriteLine("     | >--------> Welcome to our vending mashine <--------<  |\n" +
                "     |   *-*-*-*-*-*-*-*Enjoy Our Products *-*-*-*-*-*-*-*   |");
            Console.WriteLine("     |_______________________________________________________|\n ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            vendingMachine.ShowAll(MachineStock.GetAllProduct());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n__________________________________________________________\n");
            Console.Write("Current Balance:");
            moneyPool.ShowBalance();
        }
        public void ShowAllProductInfo()
        {
            Console.Clear();
            var products = MachineStock.GetAllProduct();
            Console.WriteLine($"The available products on our vending machine \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in products) item.Examine(item);
            Console.WriteLine("Backing to the main Menu in few second");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(8000);
           
        }

        // Method for vending machine process
        public bool BuyFromMachine()
        {
           
            ConsoleKey key;
            MainScreen();
            /// 
            while (moneyPool.GetBalance() < 15) //The cheapest product cost 15kr
            { 
        Console.Write($"Minmun balance to be able to buy is 15kr.\nYour balance is [{moneyPool.GetBalance()}]kr ,Add | 1kr, 2kr, 5kr, 10kr, 20kr, 50kr, 100kr, 200kr, 500kr, 1000kr |\n"+
            "Please inster money to buy or enter [0] to finish your session: ");
                var input = Console.ReadLine();
                if(input == "0")   // If the customer didn't have enough money or want to cancel the purchase
                { vendingMachine.EndTransaction(moneyPool);
                    Environment.Exit(0);
                }
                vendingMachine.InsertMoney(input);
            }
            do
            {
                MainScreen();
                int productCode; 
                    Console.Write("Enter the code of the product you want to buy or enter [*] to examine our products or [0] to finish your session: ");
                var input = Console.ReadLine();
                productCode = moneyPool.Validate(input);
                if (input == "*")/// printout the examine of all product 
                { ShowAllProductInfo(); BuyFromMachine(); }////
                if (productCode == 0)
                    break;
                vendingMachine.Purchase(productCode);
                Console.Write("Current Balance:");
                moneyPool.ShowBalance();
                Console.Write("Would you like to buy again?\n" +
                    "Press any key to buy again , + key to add more money, or Spacebar to finish and get rest of your balance\n");
                  key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Add)
                {
                    Console.Write($"Current balance :[{moneyPool.GetBalance()}]kr Please Add the money you need: ");
                    vendingMachine.InsertMoney(Console.ReadLine());
                }
            } while (key != ConsoleKey.Spacebar);
            vendingMachine.EndTransaction(moneyPool);
            return true;
        }

    }
}
