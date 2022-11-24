using OOPSPrograms.InventoryDataManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {

        static string jsonFilePath = @"E:\Bridgelabz\Oops\Opps\InventoryManagement\Inventory.json";
        static string InventoryDataPath = @"E:\Bridgelabz\Oops\Opps\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the OOPS Programs");
                Console.WriteLine(" 1. Inventory Details Management\n 2. Inventory Data Management");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        InventoryDetailManagement inventory = new InventoryDetailManagement();
                        inventory.ReadJSONFile(jsonFilePath);
                        break;
                     default:
                        flag = false;
                        Console.WriteLine("Try with right input");
                        break;
                }
            }            
        }
    }
}

