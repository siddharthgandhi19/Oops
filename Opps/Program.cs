using OOPSPrograms.InventoryDataManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string jsonFilePath = @"E:\Bridgelabz\Oops\Opps\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            InventoryDetailManagement inventory = new InventoryDetailManagement();
            inventory.ReadJSONFile(jsonFilePath);
        }
    }
}

