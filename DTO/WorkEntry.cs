using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkEntry
    {
        public int Id;
        public string input_date;
        public int employeeId;
        public string status;

        public WorkEntry()
        {
            
        }

        public WorkEntry(int Id, int employeeId, string status, string input_date)
        {
            this.Id = Id;
            this.employeeId = employeeId;
            this.status = status;
            this.input_date = input_date;
        }
    }
}
