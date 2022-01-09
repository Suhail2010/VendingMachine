using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.FolderProducts

{
    public class Sandwiches : Products
    {
        public override string Type { get { return "I am a Sandwich"; } }
        public Product name;
        public int quantity;
        public int value = 20;
        public Sandwiches(Product product, int quantity)
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
            return "How to use : Ready to eat, enjoy! :)";
        }
    }
}
