using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager
{
    public partial class JobUserControl : UserControl
    {

        private DataTable dt = new DataTable();
        private EmployeeBUS eBus;
        private DepartmentBUS deBus;
        private JobBUS jobBus;
        private Department deDto;
        private EmployeeDTO eDto;
        private Job_DetailBUS jdBus;
        private List<Job> jobList;
        private List<EmployeeDTO> elist;
        private List<Department> delist;
        private JobUserControl jobUserControl;
        private Job jobDto;
        private int index;
        private int idSelected;
        public JobUserControl()
        {
            InitializeComponent();
            jobList = new List<Job>();
            eBus = new EmployeeBUS();
            deBus = new DepartmentBUS();
            jobBus = new JobBUS();
            elist = eBus.GetAll();
            delist = deBus.GetAll();
            jobList = jobBus.GetAll();
            dt.Columns.Add("ID");
            dt.Columns.Add("Job Name");
            dt.Columns.Add("Description");

        }
       
    }
}
