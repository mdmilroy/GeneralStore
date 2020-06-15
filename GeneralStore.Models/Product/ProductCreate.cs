using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStore.Models.Product
{
    public class ProductCreate
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InventoryCount { get; set; }
        public bool IsFood { get; set; }

    }
}
