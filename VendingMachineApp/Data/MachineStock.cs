using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Data;
using VendingMachineApp.Modle;

namespace VendingMachineApp.Data
{
    public static class MachineStock
    {
        public static List<Product> availableProduct = new List<Product>();

        public static void LoadPrducts()
        {
            availableProduct.Add(new Drink("Cola Zero 1.5L", 15, "A cold drink with no suger"));
            availableProduct.Add(new Drink("Fanta Exotic 1L", 20, "A cold drink with suger"));
            availableProduct.Add( new Food("Tuna Egg Salad", 50, "Tuna with vegetables"));
            availableProduct.Add( new Food("Chicken Sandwich in bread", 40, "Chicken sandwich with mayonnaise"));
            availableProduct.Add( new Snack("Oreo Cookies (185g)", 25, "Creme slathered between two chocolate cookies"));
            availableProduct.Add( new Snack("M&M's (25g)", 20, "M&M's with all flavor, has peanut"));
        }

        public static Product GetProduct(int productId)
        {
            
            foreach (var item in availableProduct)
            {
                if (item.ProductId == productId)
                    return item;
            }
            return null; 
        }

        public static List<Product> GetAllProduct()
        {
            
            return availableProduct;
        }
    }
}
