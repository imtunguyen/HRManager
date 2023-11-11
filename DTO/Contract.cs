using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class Contract
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int EmployeeId { get; set; }
		public DateTime FormDate { get; set; }
		public DateTime ToDate { get; set; }
		public string Status { get; set; }
		public int JobId { get; set; }
		public int DepartmentId { get; set; }
		public int HrId { get; set; }
		public string Detail { get; set; }
		public int RequiredDay { get; set; }
		// Get, Update
		public Contract(int id, string name, int employeeId, DateTime formDate, DateTime toDate, string status, int jobId, int departmentId, int hrID, string detail, int requiredDay)
		{
			Id = id;
			Name = name;
			EmployeeId = employeeId;
			FormDate = formDate;
			ToDate = toDate;
			Status = status;
			JobId = jobId;
			DepartmentId = departmentId;
			HrId = hrID;
			Detail = detail;
			RequiredDay = requiredDay;
		}
		// Add
		public Contract(string name, int employeeId, DateTime formDate, DateTime toDate, string status, int jobId, int departmentId, int hrID, string detail, int requiredDay)
		{
			Name = name;
			EmployeeId = employeeId;
			FormDate = formDate;
			ToDate = toDate;
			Status = status;
			JobId = jobId;
			DepartmentId = departmentId;
			HrId = hrID;
			Detail = detail;
			RequiredDay = requiredDay;
		}
	}
}
