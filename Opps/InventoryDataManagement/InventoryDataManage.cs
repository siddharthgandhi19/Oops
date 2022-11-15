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
        public void ReadJSONFile(string file)
        {
            var jsondata = File.ReadAllText(file);
            InventoryData inventories = JsonConvert.DeserializeObject<InventoryData>(jsondata);
            List<Inventory> RiceList = inventories.Rice;
            Display(RiceList);
            List<Inventory> WheatList = inventories.Wheat;
            Display(WheatList);
            List<Inventory> PulsesList = inventories.Pulses;
            Display(PulsesList);

        }
        public void Display(List<Inventory> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine("Inventory Name: " + data.Name + "\n" + "Weight: " + data.Weight + "\n" + "Price Per Kg: " + data.PricePerKg + "\n" + "Total Price: " + data.Weight * data.PricePerKg);
            }
        }
    }
}
