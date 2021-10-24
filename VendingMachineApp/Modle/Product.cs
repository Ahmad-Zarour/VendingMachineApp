using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Modle
{
    public abstract class Product
    {
        public Product()
        { }
        public Product (int productId)
        {
            ProductId = productId;
        }
        public int ProductId{ get;  set; }
        public string ProductName { get; set; }
        private int price;
        public string ProductDescription { get; set; }
        public string UsageInformation { get; set; }

        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price of product can not be equal to zero");
                else
                    price = value;
            }
        }

        //Show the product’s price and info , not used 
        public virtual void Examine(Product product) 
        {
            Console.WriteLine($"{product.ProductName} <--> cost [{product.price}]kr <--> info: {product.ProductDescription}");
        }
        //Use method to to return message how to use the product
        public virtual void Use(Product product) 
        {
            Console.WriteLine($"Here are some tips about {product.ProductName} : {product.UsageInformation}");
        }

    }
}