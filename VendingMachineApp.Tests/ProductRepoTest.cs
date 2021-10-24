using System;
using Xunit;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;


namespace VendingMachineApp.Tests
{
    public class ProductRepoTest
    {
        /// test GetAllProduct method
        [Fact]
        public void GetAllProductShould_ReturnAllProduct()
        {
            /* testing with the products
             1 -drinkProduct
                ProductId =3
                ProductName = "Ice Coffee",
                Price = 30,
             2-SandwichProduct
                ProductId =7
                ProductName = "Tuna Salad Sandwich",
                Price = 35,*/

            var sut = new ProductRepo();
            var acutal = sut.GetAllProduct();
            var drinkProduct = sut.RetrieveByProductId(3);
            var SandwichProduct = sut.RetrieveByProductId(7);
            Assert.Equal(3, drinkProduct.ProductId);
            Assert.Equal("Ice Coffee", drinkProduct.ProductName);
            Assert.Equal(30, drinkProduct.Price);
            Assert.Equal(7, SandwichProduct.ProductId);
            Assert.Equal("Tuna Salad Sandwich", SandwichProduct.ProductName);
            Assert.Equal(35, SandwichProduct.Price);
            
        }






        /// test RetrieveByProductId method
        [Fact]
        public void RetrieveByProductIdShould_ReturnProduct()
        {
            /* testing with the product 
             * ProductId =2
             *  ProductName = "Sprit Zero"
                Price = 20
                ProductDescription = "A cold drink with no suger"
                UsageInformation = "Drink it directly , Wait few second before opening"*/

            var sut = new ProductRepo();
            var acutal = sut.RetrieveByProductId(2);
            Assert.Equal(2, acutal.ProductId);
            Assert.Equal("Sprit Zero", acutal.ProductName);
            Assert.Equal(20, acutal.Price);
            Assert.Equal("A cold drink with no suger", acutal.ProductDescription);
            Assert.Equal("Drink it directly , Wait few second before opening", acutal.UsageInformation);
        }


    }
}
