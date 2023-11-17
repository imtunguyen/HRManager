using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployeeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public DateTime? Date_Joined { get; set; }
        public DateTime? Date_Left { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string img_path { get; set; }
        public Decimal base_pay { get; set; }

        public EmployeeDTO()
        {
            
        }

        public EmployeeDTO(int ID, string Name, string Gender, DateOnly Date_of_Birth, DateOnly Day_Joined, DateOnly Day_Left, string Phone,
            string Email, string Status, string img_path, Decimal base_pay)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Email = Email;
            this.Status = Status;
            this.Date_Left = Date_Left;
            this.Date_Joined = Date_Joined;
            this.Date_Left = Date_Left;
            this.Phone = Phone;
            this.img_path = img_path;
            this.base_pay = base_pay;
        }
    }
}
