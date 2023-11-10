using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class JobBUS
    {
        public JobDAO jobDAO;
        public JobBUS()
        {
            jobDAO = JobDAO.getInstance();
        }

    }

}
