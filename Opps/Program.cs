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
            InventoryDataManage manage = new InventoryDataManage();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the OOPS Programs");
                Console.WriteLine(" 1. Inventory Details Management\n 2. Inventory Data Management\n 3. Display\n 4. Add Inventory Data\n 5. Edit Inventory Data\n 6. Delete Whole Inventory List\n 7. Delete Selected Data");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        InventoryDetailManagement inventory = new InventoryDetailManagement();
                        inventory.ReadJSONFile(jsonFilePath);
                        break;
                    case 2:                        
                        manage.ReadJSONFile(InventoryDataPath);
                        manage.Display();
                        break;
                    case 3:
                        manage.Display();
                        break;
                    case 4:
                        manage.ReadJSONFile(InventoryDataPath);
                        Console.Write("Enter Inventory Name to add(Rice, Wheat, Pulses) : ");
                        string addName = Console.ReadLine();
                        manage.AddInventoryData(addName);
                        manage.WriteJsonFile(InventoryDataPath);
                        break;
                    case 5:
                        manage.ReadJSONFile(InventoryDataPath);
                        Console.Write("Enter Inventory Name to add(Rice, Wheat, Pulses) : ");
                        string editName = Console.ReadLine();
                        manage.EditInventoryData(editName);
                        manage.WriteJsonFile(InventoryDataPath);
                        break;
                    case 6:
                        manage.ReadJSONFile(InventoryDataPath);
                        Console.Write("Enter Inventory Name to delete(Rice, Wheat, Pulse) : ");
                        string deleteAll = Console.ReadLine();
                        manage.AllDelteInventoryData(deleteAll);
                        manage.WriteJsonFile(InventoryDataPath);
                        break;
                    case 7:
                        manage.ReadJSONFile(InventoryDataPath);
                        Console.Write("Enter Inventory Name to delete(Rice, Wheat, Pulse) : ");
                        string deleteName = Console.ReadLine();
                        manage.DeleteInventoryData(deleteName);
                        manage.WriteJsonFile(InventoryDataPath);
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

