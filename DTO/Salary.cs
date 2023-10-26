using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Salary
    {
        public Salary() { }
        public int ID { get; set; }
        public int Time { get; set; }
        public int Employee_ID { get; set; }
        public float Total { get; set; }

        public Salary(int ID, int Time, int Employee_ID, float Total)
        {
            this.ID = ID;
            this.Time = Time;
            this.Employee_ID = Employee_ID;
            this.Total = Total;
        }
    }
}
