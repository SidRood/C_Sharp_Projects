/* Assignment 10 - IS350
 * This program will design stores and manage their inventories
 * Sidney Rood
 */
namespace Assignment10
{
    internal class Assignment10
    {
        static void Main(string[] args)
        {
            //create 3 new stores
            Store s1 = new Store();
            Store s2 = new Store(4, true);
            Store s3 = new Store(3, false);
            //call setInventoryEasy for store 1 and 2
            s1.setInventoryEasy();
            s3.setInventoryEasy();
            //call setInventory for store 2 and add any items 
            s2.setInventory();
            Console.WriteLine();
            //call storeDetails for each store
            s1.storeDetails();
            s2.storeDetails();
            s3.storeDetails();
        }//main method
    }//class

    class Store
    {
        static int storeCounter = 1;
        string[] inventory;
        int storeID;
        bool isOpen;

        public Store()
        {
            storeID = storeCounter;
            storeCounter++;
            isOpen = true;
            inventory = new string[3];
        }//default constructor

        public Store(int iNum, bool op)
        {
            storeID = storeCounter;
            storeCounter++;
            isOpen = op;
            inventory = new string[iNum];
        }//two parameter constructor

        public void setInventory()
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine("Please input an inventory item:");
                inventory[i] = Console.ReadLine()!;
            } 
        }//setInventory method

        public void setInventoryEasy()
        {
            inventory[0] = "Shoes";
            inventory[1] = "Shirts";
            inventory[2] = "Pants";
            //string[] inventory = { "Shoes", "Shirts", "Pants" };
        }//setInventoryEasy method

        public void storeDetails()
        {
            Console.WriteLine("Store ID: {0}\nOpen: {1}", storeID, isOpen);
            Console.WriteLine("Inventory items:");
            foreach (string item in inventory)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }//store class
}//namespace