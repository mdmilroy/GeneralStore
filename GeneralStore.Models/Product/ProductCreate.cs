using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStore.Models.Product
{
    public class ProductCreate
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        [Range(0,100)]
        public int InventoryCount { get; set; }
        
        [Required]
        public bool IsFood { get; set; }

    }
}
