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
        public DateTime Day_Joined { get; set; }
        public DateTime Day_Left { get; set; }
        public int Phone { get; set; }
        public String Status { get; set; }
        public string Email { get; set; }
        public string img_path { get; set; }
        public double base_pay { get; set; }

        public EmployeeDTO()
        {
            
        }

        public EmployeeDTO(int ID, string Name, string Gender, DateTime Date_of_Birth, DateTime Day_Joined, DateTime Day_Left, int Phone,
            string Email, String Status, string img_path, double base_pay)
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
