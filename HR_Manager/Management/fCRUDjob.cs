using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Manager.Management
{
	public partial class fCRUDjob : Form
	{
		private JobUserControl jobUserControl;
		private Job jobDto;
		private int id;
		public fCRUDjob(JobUserControl job)
		{
			InitializeComponent();
			jobUserControl = job;
			txtName.Focus();
		}
		public fCRUDjob(JobUserControl job, Job jobDTO)
		{
			InitializeComponent();
			jobUserControl = job;
			lblJob.Text = "UPDATE JOB";
			btnCreate.Text = "UPDATE";
			jobDto = jobDTO;
			id = jobDTO.ID;
			LoadFields();

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				if (btnCreate.Text == "ADD")
				{
					if (checkValidInput())
					{
						JobBUS jobBus = new JobBUS();
						Job job = GetJob();
						if (jobBus.Add(job))
						{
							MessageBox.Show(SD.addSuccess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
							jobUserControl.loadDataGridView();
							this.Dispose();
						}
						else
						{
							MessageBox.Show(SD.addFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);

						}
					}
				}
				else if (btnCreate.Text == "UPDATE")
				{
					if (checkValidInput())
					{
						JobBUS jobBus = new JobBUS();
						Job job = GetJob();
						if (jobBus.Update(id, job))
						{
							MessageBox.Show(SD.UpdateSucess, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);
							jobUserControl.loadDataGridView();
							this.Dispose();
						}
						else
						{
							MessageBox.Show(SD.UpdateFail, SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Information);

						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error" + ex, SD.tb);
			}

		}
		private Job GetJob()
		{
			Job job = new Job();
			job.Job_Name = txtName.Text;
			job.Description = txtDescription.Text;
			return job;
		}
		private void LoadFields()
		{
			try
			{
				if (jobDto != null)
				{
					txtName.Text = jobDto.Job_Name;
					txtDescription.Text = jobDto.Description;
				}
			}
			catch (Exception ex)
			{

			}
		}
		private bool checkValidInput()
		{
			if ((string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtDescription.Text)))
			{
				MessageBox.Show("Please fill out the required information!", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
