using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CategoryPropertyItem
    {
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int PropertyItemID { get; set; }
        public PropertyItem PropertyItem { get; set; }
    }
}
