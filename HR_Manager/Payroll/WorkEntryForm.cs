using BUS;
using HR_Manager.Payroll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Employee
{
    public partial class WorkEntryForm : Form
    {
        private List<DTO.Employee> employees;
        private WorkEntryBUS workEntryBUS;
        private EmployeeBUS employeeBUS;
        private string date = WorkEntry.static_year + "-" + WorkEntry.static_month + "-" + UserControlDay.static_day;
        public WorkEntryForm()
        {
            InitializeComponent();
        }

        private void WorkEntryForm_Load(object sender, EventArgs e)
        {
            render();
        }
        private void render()
        {
            label1.Text = date;

            workEntryBUS = new WorkEntryBUS();
            employeeBUS = new EmployeeBUS();
            employees = employeeBUS.getAll();

            for (int i = 0; i < employees.Count; i++)
            {
                checkedListBox1.Items.Add(employees[i].ID + "_" + employees[i].Name);
                if (workEntryBUS.IsEmployeeDone(date, employees[i].ID))
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked && !workEntryBUS.IsEmployeeExistInDatabase(date, employees[i].ID))
                {
                    DTO.WorkEntry workEntry = new DTO.WorkEntry();
                    workEntry.employeeId = employees[i].ID;
                    workEntry.input_date = date;
                    workEntry.status = "done";
                    bool add = workEntryBUS.Add(workEntry);
                }
                if(checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked && workEntryBUS.IsEmployeeExistInDatabase(date, employees[i].ID))
                {
                    DTO.WorkEntry workEntry = new DTO.WorkEntry();
                    workEntry.employeeId = employees[i].ID;
                    workEntry.input_date = date;
                    workEntry.status = "undone";
                    bool update = workEntryBUS.Update(workEntry);
                }
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked && workEntryBUS.IsEmployeeExistInDatabase(date, employees[i].ID))
                {
                    DTO.WorkEntry workEntry = new DTO.WorkEntry();
                    workEntry.employeeId = employees[i].ID;
                    workEntry.input_date = date;
                    workEntry.status = "done";
                    bool add = workEntryBUS.Update(workEntry);
                }
            }
            button1.Visible = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }
    }
}
