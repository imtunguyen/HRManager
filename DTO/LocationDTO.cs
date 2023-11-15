using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LocationDTO
    {
        
        public int ID { get; set; }
        public string Address { get; set; }
        public LocationDTO() { }
        public LocationDTO(int id, string address)
        {
            ID = id;
            Address = address;
        }
    }
}
