using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Device
    {
        public int ID { get; set; }
        public string DeviceName { get; set; }
        public string DeviceCategory { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string Memo { get; set; }
        public int CategoryID { get; set; } 
        public Category Category { get; set; }

    }
}
