using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStore.Models.Product
{
    public class ProductListItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int inventoryCount { get; set; }
        public decimal Price { get; set; }
        public bool IsFood { get; set; }
    }
}
