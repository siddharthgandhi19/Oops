using Newtonsoft.Json;
using Opps.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps.InventoryDataManagement
{
    public class InventoryDataManage
    {
        List<Inventory> RiceList;
        List<Inventory> WheatList;
        List<Inventory> PulsesList;
        InventoryData inventories;
        public void ReadJSONFile(string file)
        {
            var jsonData = File.ReadAllText(file);
            inventories = JsonConvert.DeserializeObject<InventoryData>(jsonData);
            RiceList = inventories.Rice;
            WheatList = inventories.Wheat;
            PulsesList = inventories.Pulses;

        }
        public void Display()
        {
            Read(RiceList);
            Read(WheatList);
            Read(PulsesList);
        }
        public void Read(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name + " " + data.Weight + " " + data.PricePerKg);
            }
            Console.WriteLine();
        }

        public void AddInventoryData(string inventoryName)
        {
            Inventory inventory = new Inventory();
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    inventory.PricePerKg = Convert.ToDouble(Console.ReadLine());
                    RiceList.Add(inventory);
                    break;
                case "Wheat":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    inventory.PricePerKg = Convert.ToDouble(Console.ReadLine());
                    WheatList.Add(inventory);
                    break;
                case "Pulses":
                    Console.Write("Enter the name : ");
                    inventory.Name = Console.ReadLine();
                    Console.Write("Enter the Weight : ");
                    inventory.Weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Price");
                    inventory.PricePerKg = Convert.ToDouble(Console.ReadLine());
                    PulsesList.Add(inventory);
                    break;
            }
        }

        public void EditInventoryData(string inventoryName)
        {
            switch (inventoryName)
            {
                case "Rice":
                    Console.Write("enter name : ");
                    string nameRice = Console.ReadLine();
                    foreach (var rice in RiceList)
                    {
                        if (rice.Name.Equals(nameRice))
                        {
                            Console.Write("enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            rice.Name = editName;
                            rice.Weight = editWeight;
                            rice.PricePerKg = editPrice;
                        }
                    }
                    break;
                case "Wheat":
                    Console.Write("enter name : ");
                    string nameWheat = Console.ReadLine();
                    foreach (var wheat in WheatList)
                    {
                        if (wheat.Name.Equals(nameWheat))
                        {
                            Console.Write("enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            wheat.Name = editName;
                            wheat.Weight = editWeight;
                            wheat.PricePerKg = editPrice;
                        }
                    }
                    break;
                    case "Pulses":
                    Console.Write("enter name : ");
                    string namePulse = Console.ReadLine();
                    foreach (var pulse in PulsesList)
                    {
                        if (pulse.Name.Equals(namePulse))
                        {
                            Console.Write("enter name to edit : ");
                            string editName = Console.ReadLine();
                            Console.Write("enter weight to edit : ");
                            int editWeight = Convert.ToInt32(Console.ReadLine());
                            Console.Write("enter price to edit : ");
                            double editPrice = Convert.ToDouble(Console.ReadLine());
                            pulse.Name = editName;
                            pulse.Weight = editWeight;
                            pulse.PricePerKg = editPrice;
                        }
                    }
                    break;
            }
        }

        public void AllDelteInventoryData(string inventoryName)
        {
            switch (inventoryName)
            {
                case "Rice":
                    RiceList.Clear();
                    break;
                case "Wheat":
                    WheatList.Clear();
                    break;
                case "Pulse":
                    PulsesList.Clear();
                    break;
            }
        }



        public void WriteJsonFile(string file)
        {
            var json = JsonConvert.SerializeObject(inventories);
            File.WriteAllText(file, json);
        }
    }
}
    