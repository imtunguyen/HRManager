using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Job
    {
        public int ID {  get; set; }
        public string Job_Name { get; set; }

        public Job()
        {
            
        }

        public Job(int ID, string Job_Name)
        {
            this.ID = ID;
            this.Job_Name = Job_Name;
        }
    }
}
