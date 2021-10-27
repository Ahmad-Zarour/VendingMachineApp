using System;
using Xunit;
using VendingMachineApp.Modle;
using VendingMachineApp.Data;

namespace VendingMachineApp.Tests
{
    public class MachineStockTest
    {
        [Fact]
        public void LoadPrductsShould_CreateNewProducts()
        {
            
            MachineStock.LoadPrducts();
            var actual1 = "Cola Zero 1.5L";
            var actual2 = 3;
            var actual3 = "M&M's with all flavor, has peanut";
            var sut = MachineStock.availableProduct.ToArray();
            Assert.Equal(sut[0].ProductName, actual1);
            Assert.Equal(sut[2].ProductId, actual2);
            Assert.Equal(sut[5].ProductDescription, actual3);
        }
        
        [Fact]
        public void GetProductShould_FindProductById()
        {
            MachineStock.LoadPrducts();
            var actual = 3;
            var actual1 = "Tuna Egg Salad";
            var actual2 = 50;
            var actual3 = "Tuna with vegetables";
            var sut = MachineStock.GetProduct(3);
            Assert.Equal(sut.ProductId, actual);
            Assert.Equal(sut.ProductName, actual1);
            Assert.Equal(sut.Price, actual2);
            Assert.Equal(sut.ProductDescription, actual3);
        }

        [Fact]
        public void GetAllProductShould_REturnAllProducts()
        {

            MachineStock.LoadPrducts();
            var actual1 = "Fanta Exotic 1L";
            var actual2 = 4;
            var actual3 = 40;
            var sut = MachineStock.GetAllProduct();
            Assert.Equal(sut[1].ProductName, actual1);
            Assert.Equal(sut[3].ProductId, actual2);
            Assert.Equal(sut[3].Price, actual3);
        }

        

    }
}
