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
        public int employee_id { get; set; }
        public Decimal amount { get; set; }
        public string type { get; set; }
        public string reason { get; set; }
        public DateTime expired_date { get; set; }
        public BonusAndFines()
        {
            
        }

        public BonusAndFines(int id, int employee_id, string type, string reason, DateTime expired_date, Decimal amount)
        {
            this.id = id;
            this.employee_id = employee_id;
            this.type = type;
            this.reason = reason;
            this.expired_date = expired_date;
            this.amount = amount;
        }
    }
}
