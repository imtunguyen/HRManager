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
        public EmployeeDTO(int iD, string name, string gender, DateTime date_of_Birth, string phone, string status, string email, string img_path)
        {
            ID = iD;
            Name = name;
            Gender = gender;
            Date_of_Birth = date_of_Birth;
            Phone = phone;
            Status = status;
            Email = email;
            this.img_path = img_path;
        }

        public int RequiredDay { get; set; }
        public Decimal TotalSalary { get; set; }
        public decimal BonusTotal { get; set; }

        public decimal FinesTotal { get; set; }

        // chi tiết lương
        public EmployeeDTO(int iD, string name, int requiredDay, decimal basepay, decimal bonus, decimal fines, decimal total)
        {
            ID= iD;
            Name = name;
            RequiredDay = requiredDay; 
            base_pay = basepay;
            BonusTotal = bonus;
            FinesTotal = fines;
            TotalSalary = total;
        }

        public string Job { get; set; }
        public string Department { get; set; }
        // top 5 
        public EmployeeDTO(int id, string name, string job, string department, decimal total)
        {
            ID = id;
            Name = name;
            Job = job;
            Department = department;
            TotalSalary = total;
        }
    }
}
