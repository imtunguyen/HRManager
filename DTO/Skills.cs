using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Skills
    {
        public int ID { get; set; }
        public string Skills_Name { get; set; }
        public string description { get; set; }
        public Skills() { }
        public Skills(int ID, string Skills_Name, string description)
        {
            this.ID = ID;
            this.Skills_Name = Skills_Name;
            this.description = description;
        }
    }
}
