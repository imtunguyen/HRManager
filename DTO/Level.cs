using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Level
    {
        public int ID {  get; set; }
        public string Level_Name { get; set; }

        public Level()
        {
            
        }
        public Level(int ID, string Level_Name)
        {
            this.ID = ID;
            this.Level_Name = Level_Name;
        }
    }
}
