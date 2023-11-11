using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class SD
	{
		public const string Contract_New = "New";
		public const string Contract_Running = "Running";
		public const string Contract_Expired = "Expried";
		public const string Contract_Cacelled = "Cancelled";
		public static List<string> ListContractStatus = new List<string> { Contract_New, Contract_Running, Contract_Expired, Contract_Cacelled };

		public const string tb = "Notification";
		public const string addSuccess = "Add Success";
		public const string UpdateSucess = "Update Success";
		public const string addFail = "Add Fail";
		public const string UpdateFail = "Update Fail";
	}
}
