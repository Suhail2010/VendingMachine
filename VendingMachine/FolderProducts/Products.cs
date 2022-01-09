using System;
using System.Collections.Generic;

namespace VendingMachine.FolderProducts

{
    public abstract class Products
    {
        public abstract string Type { get; }
        public abstract double Price { get; }
        public abstract Product ProductName { get; }
        public abstract int Quantity { get; }
        public static void DisplayAllProducts()
        {
            int i = 0;
            int[] num = (int[])Enum.GetValues(typeof(Product));
            foreach (string name in Enum.GetNames(typeof(Product)))
            {
                i++;
                Console.WriteLine();
                Console.WriteLine(i + ". " + name + " " + num[i - 1] + "kr");
            }
        }
        public virtual string Info()
        {
            return "Product : ";
        }
        public abstract string Usage();

        
    }
}
