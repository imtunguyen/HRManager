using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BonusAndFines
    {
        public int id {  get; set; }
        public int salary_id { get; set; }
        public float amount { get; set; }
        public string type { get; set; }
        public string reason { get; set; }

        public BonusAndFines()
        {
            
        }

        public BonusAndFines(int id, int salary_id, string type, string reason)
        {
            this.id = id;
            this.salary_id = salary_id;
            this.type = type;
            this.reason = reason;
        }
    }
}
