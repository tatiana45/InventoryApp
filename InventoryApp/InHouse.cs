using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class InHouse : Part
    {
        private int machineID;

        public InHouse() {
            PartID = util.GetUniqueId();
        }
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
        public int MachineID { get; set; }
    }
}
