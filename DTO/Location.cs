using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Location
    {
        public Location() { }
        public int ID { get; set; }
        public string Address { get; set; }  
        public Location(int ID, string Address)
        {
            this.ID = ID;
            this.Address = Address;
        }
    }
}
