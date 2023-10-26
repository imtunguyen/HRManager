using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string Username {  get; set; }
        public string Password { get; set; }
        public int Employee_ID { get; set; }
        public DateOnly Create_Date { get; set; }

        public Account()
        {
            
        }

        public Account(string Username, string Password, DateOnly Create_Date, int Employee_ID)
        {
            this.Username = Username;
            this.Password = Password;
            this.Create_Date = Create_Date;
            this.Employee_ID = Employee_ID;
        }
    }
}
