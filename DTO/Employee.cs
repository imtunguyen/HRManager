using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateOnly Date_of_Birth { get; set; }
        public DateOnly Day_Joined { get; set; }
        public DateOnly Day_Left { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string img_path { get; set; }
        public Decimal base_pay { get; set; }

        public Employee()
        {
            
        }

        public Employee(int ID, string Name, string Gender, DateOnly Date_of_Birth, DateOnly Day_Joined, DateOnly Day_Left, int Phone,
            string Email, string Status, string img_path, Decimal base_pay)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Email = Email;
            this.Status = Status;
            this.Day_Left = Day_Left;
            this.Day_Joined = Day_Joined;
            this.Day_Left = Day_Left;
            this.Phone = Phone;
            this.img_path = img_path;
            this.base_pay = base_pay;
        }
    }
}
