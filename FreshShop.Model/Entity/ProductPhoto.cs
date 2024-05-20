using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshShop.Model.Entity
{
    public class ProductPhoto : BaseEntity
    {
        public int ProductID { get; set; }
        public string PhotoPath { get; set; }
        public virtual Product Product { get; set; }
    }
}
