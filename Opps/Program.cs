﻿using OOPSPrograms.InventoryDataManagement;
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
                Console.WriteLine(" 1. Inventory Details Management\n 2. Inventory Data Management\n 3. Display\n 4. Add Inventory");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        InventoryDetailManagement inventory = new InventoryDetailManagement();
                        inventory.ReadJSONFile(jsonFilePath);
                        break;
                    case 2:                        
                        manage.ReadJSONFile(InventoryDataPath);
                        break;
                    case 3:                        
                        manage.ReadJSONFile(InventoryDataPath);
                        Console.Write("Enter Inventory Name to add(Rice, Wheat, Pulse) : ");
                        string addName = Console.ReadLine();
                        manage.ReadJSONFile(InventoryDataPath);
                        manage.AddInventoryData(addName);
                        break;
                    case 4:
                        manage.Display();
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

