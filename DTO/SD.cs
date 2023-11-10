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
		public static List<string> ListContractStatus = new List<string> { "New", "Running", "Expired", "Cancelled" };
	}
}
