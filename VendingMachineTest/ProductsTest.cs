using System;
using Xunit;
using VendingMachine.FolderMachine;
using VendingMachine;
using VendingMachine.FolderProducts;

namespace VendingMachineTest
{
    public class ProductsTest
    {
        [Fact]
        public void DrinksNameTest()
        {
            Product name = Product.Cola;
            Product expected = Product.Cola;

            Drinks namn = new Drinks(name, 1);
            
            Assert.Equal(expected, namn.ProductName);
            //Assert.Equal(value, namn.Price);
        }
        [Fact]
        public void DrinksPriceTest()
        {
            Product name = Product.Cola;
            int value = 10;

            Drinks namn = new Drinks(name, 1);

            Assert.Equal(value, namn.Price);
        }
        [Fact]
        public void SandwichPriceTest()
        {
            Product name = Product.HotDog;
            int value = 40;

            Sandwiches namn = new Sandwiches(name, 2);

            Assert.Equal(value, namn.Price);
        }








    }
}
