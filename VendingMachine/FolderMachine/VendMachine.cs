using System;
using System.Collections.Generic;
using VendingMachine.FolderProducts;
using static System.Console;


namespace VendingMachine.FolderMachine
{
    public class VendMachine : IVendingMachines
    {
        public double TotalCost { get; set; }
        private int minstPool = 10;
        public int Pool { get; set; }
        public VendMachine()
        {
            TotalCost = 0;
        }

        public void StartVendMachine()
        {
            while (!CheckPool())
            {
                WriteLine();
                Clear();
                DisplayAllProducts();
                WriteLine("\nPlease enter coin or a dollar bill (1kr, 5kr,10kr,20kr, 50kr, 100kr, 500kr, 1000kr)");
                bool validInput = int.TryParse(ReadLine(), out int money);
                if (!validInput)
                {
                    money = -1;
                }
                else if (money == 0)
                {
                    ReturnMoney();
                    continue;
                }
                DepositeMoney(money);
            }
        }


        public void DepositeMoney(int money)
        {
            
            switch (money)
            {
                case (1):
                    Pool += 1;
                    break;
                case (5):
                    Pool += 5;
                    break;
                case (10):
                    Pool += 10;
                    break;
                case (20):
                    Pool += 20;
                    break;
                case (50):
                    Pool += 50;
                    break;
                case (100):
                    Pool += 100;
                    break;
                case (500):
                    Pool += 500;
                    break;
                case (1000):
                    Pool += 1000;
                    break;
                case (0):
                    ReturnMoney();
                    break;
                default:
                    WriteLine("Invalid Entry");
                    System.Threading.Thread.Sleep(800);
                    break;
            }
        }
        public bool CheckPool()
        {
            if (Pool >= minstPool)
                return true;
            else
                return false;
        }

        public bool CheckTotal()
        {
            if (Pool >= TotalCost)
                return true;
            else
                return false;
        }
        public void DisplayAllProducts()
        {
            int i = 0;
            int[] num = (int[])Enum.GetValues(typeof(Product));
            foreach (string name in Enum.GetNames(typeof(Product)))
            {
                i++;

                WriteLine();
                WriteLine(i + ". " + name + " " + (num[i - 1] - i) + "kr");
            }
            WriteLine("\n\n0. End Order.");
        }
        public void MakeOrder()
        {
            List<Products> orders = new List<Products>();
            bool ok = true;
            while (ok)
            {
                Clear();
                DisplayAllProducts();
                WriteLine("\n");
                if (orders.Count > 0)
                {
                    TotalCost = 0;
                    WriteLine("Order Details :\n");
                    foreach (Products order in orders)
                    {
                        WriteLine(order.Info() + " x " + order.Quantity + " = {0:C}", order.Price + "    " + order.Usage());
                        TotalCost += order.Price;
                    }

                    WriteLine("\nOrder total value {0:C}    Remaining money in the pool {1:C}"
                        , TotalCost, Pool - TotalCost);
                }
                
                // call Choice 
                int choice = ChoiceInput();
                if (choice == 0)
                {
                    orders.Clear();
                    ok = false;
                    continue;
                } 
                else if (choice == -1)
                {
                    continue;
                }

                // call Quantity
                int quantity = QuantityInput();

                Products newOrder = Order(choice, quantity);
                System.Threading.Thread.Sleep(1500);

                if (TotalCost + newOrder.Price > Pool)
                {
                    WriteLine("Sorry! Not enogh money in the pool to place the order.");
                    ReadLine();
                    continue;
                }
                orders.Add(newOrder);
            }
        }
        // choose Product
        public int ChoiceInput()
        {
            bool loop = true;
            int choice = 0;
            WriteLine("\nPlease choose a number");
            while (loop)
            {
                bool validInput = int.TryParse(ReadLine(), out choice);
                if (!validInput || choice < 0 || choice > 9)
                {
                    WriteLine("Invalid selection. PLease re-enter your selection: ");
                    choice = -1;
                    loop = false;
                }
                else if (choice == 0)
                {
                    ReturnMoney();
                    loop = false;
                }
                else loop = false;
            }
            return choice;
        }
        // choose quantity
        public int QuantityInput()
        {
            bool loop = true;
            int quantity = 0;
            WriteLine("How many ");
            while (loop)
            {
                bool validInput = int.TryParse(ReadLine(), out quantity);
                if (!validInput || quantity < 1 || quantity > 20)
                {
                    WriteLine("PLease re-enter your selection (quantity between 1 and max 20) : ");
                }
                else loop = false;
            }
            return quantity;
        }

        public Products Order(int choice, int quantity)
        {
            Products order = new Drinks(0,0);
            WriteLine();
            if (choice < 4)
            {
                choice += 10;
                order = new Drinks((Product)choice, quantity);
                WriteLine("Thank you for choosing a " + (Product)choice);
                //return order;

            }
            else if (choice < 7)
            {
                choice += 20;
                WriteLine("Thank you for choosing a " + (Product)choice);
                order = new Sandwiches((Product)choice, quantity);
                //return order;

            }
            else if (choice < 10)
            {
                choice += 25;
                WriteLine("Thank you for choosing a " + (Product)choice);
                order = new Toys((Product)choice, quantity);
                //return order;

            }
            //Console.WriteLine("No condicion is met check order method.");
            //Console.ReadLine();
            return order;
        }

        private void ReturnMoney()
        {
            if (Pool > TotalCost || TotalCost == 0)
            {
                if (Pool > 0)
                {
                    WriteLine("Money to return is {0:C}", Pool - TotalCost);

                    Pool = 0;
                    TotalCost = 0;
                }
                WriteLine("\nThankyou for using the VendMachine. Have a nice day :)");
                WriteLine("Please press Enter ");
                ReadLine();
                Clear();
                //DisplayAllProducts();
            }
        }


    }
}
