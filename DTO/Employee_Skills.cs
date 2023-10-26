using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee_Skills
    {
        public Employee_Skills() { }
        public int ID { get; set; }
        public int Skill_ID { get; set; }
        public int Level_ID { get; set; }
        public int Employee_ID { get; set; }

        public Employee_Skills(int ID, int Skill_ID, int Level_ID, int Employee_ID)
        {
            this.ID = ID;
            this.Skill_ID = Skill_ID;
            this.Level_ID = Level_ID;
            this.Employee_ID = Employee_ID;
        }
    }
}
