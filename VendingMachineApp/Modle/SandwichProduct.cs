using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Modle
{
    public class SandwichProduct : Product
    {
        public SandwichProduct():this(0)
        {
                
        }

        public SandwichProduct(int productId):base (productId)
        {
            ProductId = productId;
            productsList = new List<Product>();
        }

        public List<Product> productsList { get; set; }

        // get all available Sandwich Products stored as hard coding
        public IEnumerable<Product> RetrieveSandwichProduct()
        {
            var availableSandwich = new List<Product>();
            SandwichProduct sandwichProduct = new SandwichProduct(7)
            {
                ProductName = "Tuna Salad Sandwich",
                Price = 35,
                ProductDescription = "A cold Sandwich with vegetables",
                UsageInformation = "Eat it directly , keep it cold"
            };
            availableSandwich.Add(sandwichProduct);
            sandwichProduct = new SandwichProduct(8)
            {
                ProductName = "Chicken sandwich",
                Price = 30,
                ProductDescription = " Chicken sandwich with mayonnaise",
                UsageInformation = "Eat it directly ,keep it cold"
            };
            availableSandwich.Add(sandwichProduct);

            sandwichProduct = new SandwichProduct(9)
            {
                ProductName = "Beef steak sandwich",
                Price = 60,
                ProductDescription = "Beef steak with hot sous",
                UsageInformation = "Better to warm it in the microwave,not suitable for children"
            };
            availableSandwich.Add(sandwichProduct);
            return availableSandwich;
        }
       
    }
}