using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Job_Detail
    {
		public Job_Detail() { }
		public int ID { get; set; }
		public int EmployeeID { get; set; }
		public int DepartmentID { get; set; }
		public int JobID { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime ToDate { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }

		public Job_Detail(int ID, int EmployeeID, int JobID, int DepartmentID,
			DateTime FromDate, DateTime ToDate, string Description, string Status)
		{
			this.ID = ID;
			this.EmployeeID = EmployeeID;
			this.JobID = JobID;
			this.DepartmentID = DepartmentID;
			this.FromDate = FromDate;
			this.ToDate = ToDate;
			this.Description = Description;
			this.Status = Status;
		}

		public Job_Detail(int EmployeeID, int JobID, int DepartmentID,
			DateTime FromDate, DateTime ToDate, string Description, string Status)
		{
			this.EmployeeID = EmployeeID;
			this.JobID = JobID;
			this.DepartmentID = DepartmentID;
			this.FromDate = FromDate;
			this.ToDate = ToDate;
			this.Description = Description;
			this.Status = Status;
		}
	}
}
