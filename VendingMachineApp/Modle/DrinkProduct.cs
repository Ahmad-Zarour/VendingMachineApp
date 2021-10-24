using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachineApp.Modle
{

    public class DrinkProduct : Product
    {
        public DrinkProduct():this(0)
        {
        }
        public DrinkProduct (int productId): base(productId)
                           
        {
            ProductId = productId;
            productsList = new List<Product>();
        }
        public List<Product> productsList { get; set; }

        // get all available Drink Products stored as hard coding
        public IEnumerable<Product> RetrieveDrinkProduct()
        {
            var availableDrinks = new List<Product>();
            DrinkProduct drinkProduct = new DrinkProduct(1)
            {
                ProductName = "Coca-Cola Zero",
                Price = 15,
                ProductDescription = "A cold drink with no suger",
                UsageInformation = "Drink it directly , Wait few second before opening"
            };
            availableDrinks.Add(drinkProduct);
            drinkProduct = new DrinkProduct(2)
            {
                ProductName = "Sprit Zero",
                Price = 20,
                ProductDescription = "A cold drink with no suger",
                UsageInformation = "Drink it directly , Wait few second before opening"
            };
            availableDrinks.Add(drinkProduct);
            drinkProduct = new DrinkProduct(3)
            {
                ProductName = "Ice Coffee",
                Price = 30,
                ProductDescription = "A cold coffee drink with medium sugar",
                UsageInformation = "open the plast cover and Drink it directly"
            };
            availableDrinks.Add(drinkProduct);
            return availableDrinks;
        }
    }
}