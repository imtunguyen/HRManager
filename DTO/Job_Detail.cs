using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Job_Detail
    {
        public Job_Detail() { }
        public int ID { get; set; }
        public int Employee_ID { get; set; }
        public int Job_ID { get; set; }
        public int Location_ID { get; set; }
        public DateOnly fromDate { get; set; }
        public DateOnly toDate { get; set;}

        public Job_Detail(int ID, int Employee_ID, int Job_ID, int Location_ID, 
            DateOnly fromDate, DateOnly toDate)
        {
            this.ID = ID;
            this.Employee_ID = Employee_ID;
            this.Job_ID = Job_ID;
            this.Location_ID = Location_ID;
            this.fromDate = fromDate;
            this.toDate = toDate;
        }
    }
}
