using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class PropertyItem
    {
        public int ID { get; set; }
        public string PropertiesDescription { get; set; }
        public ICollection<CategoryPropertyItem> CategoryPropertyItems { get; set; }
    }
}
