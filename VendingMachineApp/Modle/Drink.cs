using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace VendingMachineApp.Modle
{
    public class Drink : Product
    {
        public Drink( string productName, int price, string productDescription ) : 
            base(productName,  price, productDescription)
        {
            UsageInformation = "Enjoy Drink it";
        }
        //public Drink(Drink drink) : base (drink)
        //{
        //    UsageInformation = drink.UsageInformation;
        //}
    }
}