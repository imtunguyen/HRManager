using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class SD
	{
		// contract
		public const string Contract_New = "New";
		public const string Contract_Running = "Running";
		public const string Contract_Expired = "Expried";
		public const string Contract_Cacelled = "Cancelled";
		public static List<string> ListContractStatus = new List<string> { Contract_New, Contract_Running, Contract_Expired, Contract_Cacelled };

		// notification
		public const string tb = "Notification";
		public const string addSuccess = "Add Success";
		public const string UpdateSucess = "Update Success";
		public const string addFail = "Add Fail";
		public const string UpdateFail = "Update Fail";
		public const string deleteSuccess = "Delete Success";
		public const string deleteFail = "Delete Fail";
		public const string tb_delete = "Are you sure you want to delete it?";
		public const string error = "Error";

		// color
		public const string textGreen = "#099268";
		public const string textOrange = "#ffac00";

		// job_detail (quản lý công việc)
		public const string jd_draft = "Draft";
		public const string jd_validated = "Validated";
		public static List<string> ListJDStatus = new List<string> { jd_draft, jd_validated };

		// statistical
		public static List<string> listThang = new List<string> { "January", "February", "March",
		"April", "May", "June", "July", "August", "September", "October", "November", "December"};

		public static List<int> listNam = new List<int> { 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030 };
	}
}
