using System;
using System.Collections.Generic;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;

namespace VendingMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product x = MachineStock.GetProduct(2);
            //Console.WriteLine(x.ProductId);
            //Console.WriteLine(x.ProductName);
            //Console.WriteLine(StockItemSequencer.NextStockItemId());
            //Console.WriteLine(x.UsageInformation);
            MachineStock.LoadPrducts();
            VendingMachine vendingMachine = new VendingMachine();
            VendingMachineControlPanel screenVendingMachine = new VendingMachineControlPanel();
            screenVendingMachine.BuyFromMachine();
        }
    }
}
