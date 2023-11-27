using BUS;
using DTO;
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
        private List<EmployeeDTO> employees;
        private WorkEntryBUS workEntryBUS;
        private EmployeeBUS employeeBUS;
        private string date = WorkEntry.static_year + "-" + WorkEntry.static_month + "-" + UserControlDay.static_day;
        public WorkEntryForm()
        {
            InitializeComponent();
        }

        private void WorkEntryForm_Load(object sender, EventArgs e)
        {
            workEntryBUS = new WorkEntryBUS();
            employeeBUS = new EmployeeBUS();
            employees = employeeBUS.GetAll();
            render(employees);
        }
        private void render(List<EmployeeDTO> eList)
        {
            label1.Text = date;

            checkedListBox1.Items.Clear();

            for (int i = 0; i < eList.Count; i++)
            {
                checkedListBox1.Items.Add(eList[i].Name + "_" + eList[i].ID);
                if (workEntryBUS.IsEmployeeDone(date, eList[i].ID))
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
            button3.Visible = true;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                int employee_id = Convert.ToInt32(checkedListBox1.Items[i].ToString().Substring(checkedListBox1.Items[i].ToString().IndexOf("_") + 1));
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked && !workEntryBUS.IsEmployeeExistInDatabase(date, employee_id))
                {
                    DTO.WorkEntry workEntry = new DTO.WorkEntry();
                    workEntry.employeeId = employee_id;
                    workEntry.input_date = date;
                    workEntry.status = "done";
                    workEntryBUS.Add(workEntry);
                }
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Unchecked && workEntryBUS.IsEmployeeExistInDatabase(date, employee_id))
                {
                    DTO.WorkEntry workEntry = new DTO.WorkEntry();
                    workEntry.employeeId = employee_id;
                    workEntry.input_date = date;
                    workEntry.status = "undone";
                    workEntryBUS.Update(workEntry);
                }
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked && workEntryBUS.IsEmployeeExistInDatabase(date, employee_id))
                {
                    DTO.WorkEntry workEntry = new DTO.WorkEntry();
                    workEntry.employeeId = employee_id;
                    workEntry.input_date = date;
                    workEntry.status = "done";
                    workEntryBUS.Update(workEntry);
                }
            }
            MessageBox.Show("Saved");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<EmployeeDTO> list = employeeBUS.SearchByName(textBox1.Text.Trim());
            render(list);
        }
    }
}
