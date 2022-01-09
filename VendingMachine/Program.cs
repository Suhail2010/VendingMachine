using System;
using System.Collections.Generic;
using VendingMachine.FolderMachine;
using VendingMachine.FolderProducts;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {

            VendMachine vendMachine = new VendMachine();
 
            bool loop = true;
            while (loop)
            {
                vendMachine.StartVendMachine();
                /*while (!vendMachine.checkPool())
                {
                    Console.Clear();
                    vendMachine.DisplayAllProducts();
                    Console.WriteLine("\nPlease enter coin or a dollar bill (1kr, 5kr,10kr,20kr, 50kr, 100kr, 500kr, 1000kr)");
                    bool validInput = int.TryParse(Console.ReadLine(), out int money);
                    if (!validInput) money = -1;
                    vendMachine.DepositeMoney(money);
                }*/
                vendMachine.MakeOrder();
            }
            /*List<Products> orders = new List<Products>();
            bool ok = true;
            while (ok)
            {
                Console.Clear();
                vendMachine.DisplayAllProducts();
                Console.WriteLine("\n\n");
                if (orders.Count > 0)
                {
                    vendMachine.TotalCost = 0;
                    Console.WriteLine("Order Details :\n");
                    foreach (Products order in orders)
                    {
                        Console.WriteLine(order.Info() + " x " + order.Quantity + " = {0:C}", order.Price + "    " + order.Usage());
                        vendMachine.TotalCost += order.Price;
                    }
                    
                    Console.WriteLine("\nOrder total value {0:C}    Remaining money in the pool {1:C}", vendMachine.TotalCost, vendMachine.Pool - vendMachine.TotalCost);
                }

                int choice = vendMachine.ChoiceInput();
                if (choice == 0)  continue; 
                int quantity = vendMachine.QuantityInput();
                
                Products newOrder = vendMachine.Order(choice, quantity);
                System.Threading.Thread.Sleep(1500);

                if (vendMachine.TotalCost + newOrder.Price > vendMachine.Pool)
                {
                    Console.WriteLine("Sorry! Not enogh money in the pool to place the order.");
                    Console.ReadLine();
                    continue;
                }
                orders.Add(newOrder);
            }*/



        }



    }
        /*public static void DisplayAllProducts()
        {
            int i = 0;
            int[] num = (int[])Enum.GetValues(typeof(Product));
            foreach (string name in Enum.GetNames(typeof(Product)))
            {
                i++;
                Console.WriteLine();
                Console.WriteLine(i + ". " + name + " " + num[i - 1] + "kr");
            }
        }*/
        /*public static void DisplayAllProducts()
        {
            List<Products> items = new List<Products>();
            int i = 0;
            int[] num = (int[])Enum.GetValues(typeof(Product));
             
            foreach (string name in Enum.GetNames(typeof(Product)))
            {
                
                i++;
                Console.WriteLine();
                Console.WriteLine(i + ". " + name + " " + num[i-1] + "kr");
            }
        }*/


    
}
