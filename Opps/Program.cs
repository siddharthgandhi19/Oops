using OOPSPrograms.InventoryDataManagement;
using Opps.InventoryDataManagement;
using System;
namespace OOPSPrograms
{
    class Program
    {
        static string jsonFilePath = @"E:\Bridgelabz\Oops\Opps\InventoryManagement\Inventory.json";
        static string InventoryDataPath = @"E:\Bridgelabz\Oops\Opps\InventoryDataManagement\InventoryData.json";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOPS Programs");
            /* InventoryDetailManagement inventory = new InventoryDetailManagement();
             inventory.ReadJSONFile(jsonFilePath); */
            InventoryDataManage manage = new InventoryDataManage();
            manage.ReadJSONFile(InventoryDataPath);
        } 
    }
}

