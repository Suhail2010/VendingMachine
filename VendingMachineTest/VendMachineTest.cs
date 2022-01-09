using System;
using Xunit;
using VendingMachine.FolderMachine;
using VendingMachine;


namespace VendingMachine.Test
{
    public class VendMachineTest
    {
        [Fact]
        public void TestMakeOrder()
        {
            string choice = "2";
            string expected = ""; 
            
            VendMachine order = new VendMachine();
            order.DisplayAllProducts();
        }
        
        


    }
}
