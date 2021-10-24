using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;


namespace VendingMachineApp.Data
{
    public class ProductRepo : Product
    {
        public ProductRepo(int productId):base(productId)
        {
                
        }
        public ProductRepo()
        {
            drinkProduct = new DrinkProduct();
            snackProduct = new SnackProduct();
            sandwichProduct = new SandwichProduct();
        }
        public DrinkProduct drinkProduct { get; set; }
        public SnackProduct snackProduct { get; set; }
        public SandwichProduct sandwichProduct { get; set; }

        List<Product> Allproducts = new List<Product>();

        public List<Product> GetAllProduct()   // getting all product items from all classes and storing them in a list
        {
            var availableDrink = drinkProduct.RetrieveDrinkProduct().ToList();
            var availableSnack = snackProduct.RetrieveSnackProduct().ToList();
            var availableSandwich = sandwichProduct.RetrieveSandwichProduct().ToList();
            Allproducts = availableDrink.Concat(availableSnack).Concat(availableSandwich).ToList();
            return  Allproducts;
        }

        // get the product details by product Id
        public Product RetrieveByProductId(int productId)
        {
            var allProductList = GetAllProduct();
            switch (productId)
            {
                case 1:
                case 2:
                case 3:
                    var drinkProduct = new DrinkProduct(productId);
                    foreach (var item in allProductList)
                    {
                        if (item.ProductId == productId)
                            drinkProduct = (DrinkProduct)item;
                    }
                    return drinkProduct;
                case 4:
                case 5:
                case 6:
                    var snackProduct = new SnackProduct(productId);
                    foreach (var item in allProductList)
                    {
                        if (item.ProductId == productId)
                            snackProduct =(SnackProduct) item;
                    }
                    return snackProduct;
                case 7:
                case 8:
                case 9:
                    var SandwichProduct = new SandwichProduct(productId);
                    foreach (var item in allProductList)
                    {
                        if (item.ProductId == productId)
                            SandwichProduct = (SandwichProduct)item;
                    }
                    return SandwichProduct;

                default:
                    return null;
            }
        }    
    }
}
