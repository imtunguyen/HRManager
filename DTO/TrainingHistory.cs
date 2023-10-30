using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrainingHistory
    {
        public TrainingHistory() { }
        public int id { get; set; }
        public int employee_id { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public DateOnly fromDate { get; set; }
        public DateOnly toDate { get; set; }

        public TrainingHistory(int id, int employee_id, string status, string description, DateOnly fromDate, DateOnly toDate)
        {
            this.id = id;
            this.description = description;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.status = status;
            this.employee_id = employee_id;
        }
    }
}
