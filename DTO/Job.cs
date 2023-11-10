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
        public string Role { get; set; }
        public string Description { get; set; }
        public Job()
        {
            
        }

        public Job(int ID, string Job_Name, string role, string description)
        {
            this.ID = ID;
            this.Job_Name = Job_Name;
            this.Role = role;
            this.Description = description;
        }
    }
}
