using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Modle
{
    public class Food : Product
    {
        public Food(string productName,int price, string productDescription) :
            base( productName, price, productDescription)
        {
            UsageInformation = "Enjoy eating it";
        }
    }
}