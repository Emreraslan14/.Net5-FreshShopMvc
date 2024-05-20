using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Model.ViewModels
{
    public class NewProductVm
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int CategoryID { get; set; }
        public string ShortDescription { get; set; }
    }
}
