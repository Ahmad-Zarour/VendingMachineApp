using System;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;

namespace VendingMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            VendingMachineControlPanel screenVendingMachine = new VendingMachineControlPanel();
            screenVendingMachine.BuyFromMachine();
        }
    }
}
