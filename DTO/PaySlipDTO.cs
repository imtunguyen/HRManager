using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PaySlipDTO
    {
        public PaySlipDTO() { }
        public int id { set; get; }
        public int employee_id { set; get; }
        public Decimal total { set; get; }
        public string status { set; get; }
        public DateTime from_date { set; get; }
        public DateTime to_date { set; get;}
        public int Contract_ID { get; set; }
    }
}
