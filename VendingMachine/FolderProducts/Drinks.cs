using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.FolderProducts

{
    public class Drinks : Products
    {
        public override string Type { get { return "Drink"; } }
        public Product name;
        public int quantity;
        readonly int value = 10;
        public Drinks(Product product, int quantity)
        {
            this.quantity = quantity;
            name = product;
        }
        public override Product ProductName { get { return name; } }
        public override double Price { get { return quantity * value; } }
        public override int Quantity { get { return quantity; } }



        public override string Info()
        {
            return $"{base.Info()} {ProductName} {value}kr";
        }
        public override string Usage()
        {
            return "How to use : Open and Drink";
        }
    }
}
