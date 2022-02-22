using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.FolderMachine
{
    interface IVendingMachines
    {
        int Pool { get; set; }

        void DepositeMoney(int money);

        void DisplayAllProducts();

        void MakeOrder();

        void ReturnMoney();
    }
}
