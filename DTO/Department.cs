﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Department
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Address_Detail { get; set; }

        public Department()
        {
            
        }

        public Department(int ID, string Name, string Address_Detail)
        {
            this.Address_Detail = Address_Detail;
            this.ID = ID;
            this.Name = Name;
        }
    }
}
