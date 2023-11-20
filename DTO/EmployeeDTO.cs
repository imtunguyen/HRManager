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
        public string Phone { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public int Department_id { get; set; }
        public string img_path { get; set; }
        public Decimal base_pay { get; set; }

        public EmployeeDTO()
        {
            
        }
        public EmployeeDTO(int iD, string name, string gender, DateTime date_of_Birth, string phone, string status, string email, int department_id, string img_path, decimal base_pay)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Date_of_Birth = date_of_Birth;
            Phone = phone;
            Status = status;
            Email = email;
            Department_id = department_id;
            this.img_path = img_path;
            this.base_pay = base_pay;
        }
    }
}
