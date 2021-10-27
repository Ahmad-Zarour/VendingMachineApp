using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Data;

namespace VendingMachineApp.Modle
{
    public abstract class Product
    {
        public Product(string productName,int price, string productDescription)
        {
            ProductId = StockItemSequencer.NextStockItemId();
            ProductName = productName;
            Price = price;
            ProductDescription = productDescription;
        }

        public Product(Product product)
        {
            ProductId = product.ProductId;
            ProductName = product.ProductName;
            Price = product.Price;
            ProductDescription = product.ProductDescription;
        }

        public  int ProductId { get; set; }
        public string ProductName { get; set; }
        private  int _price { get; set; }
        public string ProductDescription { get; set; }
        public string UsageInformation { get; set; }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price of product can not be equal to zero");
                else
                    _price = value;
            }
        }

        //Show the product’s price and info , not used 
        public virtual void Examine(Product product) 
        {
           Console.WriteLine($"{product.ProductName} <--> cost [{product.Price}]kr <--> info: {product.ProductDescription}");
        }
        //Use method to to return message how to use the product
        public virtual void Use(Product product) 
        {
            Console.WriteLine($"Here are some tips about {product.ProductName} : {product.UsageInformation}");
        }

    }
}