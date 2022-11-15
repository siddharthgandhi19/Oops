using Newtonsoft.Json;
using Opps.InventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPrograms.InventoryDataManagement
{
    public class InventoryDetailManagement
    {
        public void ReadJSONFile(string file)
        {
            var jsondata = File.ReadAllText(file);
            List<Inventory> inventory = JsonConvert.DeserializeObject<List<Inventory>>(jsondata);
            foreach (var data in inventory)
            {
                Console.WriteLine("Inventory Name: " + data.Name + "\n" + "Weight: " + data.Weight + "\n" + "Price Per Kg: " + data.PricePerKg + "\n" + "Total Price: " + data.Weight * data.PricePerKg);
            }
        }
    }
}  