using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Modle
{
    public class SnackProduct : Product
    {
        public SnackProduct():this(0)
        {
        }
        public SnackProduct(int productId):base(productId)
        {
            ProductId = productId;
            productsList = new List<Product>();
        }

        public List<Product> productsList { get; set; }

        // get all available Snack Products stored as hard coding
        public IEnumerable<Product> RetrieveSnackProduct()
        {
            var availableSnack = new List<Product>();
            SnackProduct snackProduct = new SnackProduct(4)
            {
                ProductName = "Oreo Cookies",
                Price = 15,
                ProductDescription = "Creme slathered between two chocolate cookies",
                UsageInformation = "Eat it now or later,Recommend with milk or tea"
            };
            availableSnack.Add(snackProduct);
            snackProduct = new SnackProduct(5)
            {
                ProductName = "M&M's",
                Price = 25,
                ProductDescription = "M&M's with all flavor, has peanut",
                UsageInformation = "Eat it now or later,suitable for kids"
            };
            availableSnack.Add(snackProduct);

            snackProduct = new SnackProduct(6)
            {
                ProductName = "Lay's Chips",
                Price = 20,
                ProductDescription = "Lay's Classic Potato Chips are crispy and have enough salty goodness",
                UsageInformation = "Eat it now or later,suitable for all"
            };
            availableSnack.Add(snackProduct);
            return availableSnack;
        }  
    }
}
