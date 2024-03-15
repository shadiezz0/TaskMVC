using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public List<string> Properties { get; set; }
        public ICollection<Device> Devices { get; set; }
        public ICollection<CategoryPropertyItem> CategoryPropertyItems { get; set; }
    }
}
