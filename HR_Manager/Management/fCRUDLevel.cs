using BUS;
using DTO;
using HR_Manager.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR_Manager.Management
{
	public partial class fCRUDLevel : Form
	{
		private Level levelUpdate = null;
		private LevelUserControl levelUserControl;
		LevelBUS levelBUS = new LevelBUS();
		public fCRUDLevel(LevelUserControl u, Level objUpdate = null)
		{
			InitializeComponent();
			levelBUS = new LevelBUS();
			levelUserControl = u;
			PopulateComboBox();
			cbID.Enabled = false;
			if (objUpdate != null)
			{
				levelUpdate = objUpdate;
				this.Text = "Level management - Update";
				lblHeading.Text = "Level management - Update";
				txtLevel.Text = levelUpdate.Level_Name;
				cbID.SelectedIndex = cbID.FindStringExact(levelUpdate.ID.ToString());
				cbID.Enabled = false;

				txtLevel.Text = levelUpdate.Level_Name;
			}
			else
			{
				// Set cbID value for new level
				int maxId = levelBUS.GetMaxLevelId();
				cbID.SelectedIndex = cbID.FindStringExact((maxId + 1).ToString());
			}

		}
		private void PopulateComboBox()
		{
			// Get data for ComboBox
			List<Level> levels = levelBUS.GetAllLevels();

			// Bind data to ComboBox
			cbID.DataSource = levels;
			cbID.DisplayMember = "ID";
			cbID.ValueMember = "ID";
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string levelName = txtLevel.Text;

			if (string.IsNullOrWhiteSpace(levelName))
			{
				MessageBox.Show("Level name is required");
				return;
			}

			Level level = new Level();

			if (levelUpdate == null)
			{
				// Thêm mới
				level.Level_Name = levelName;
				if (levelBUS.AddLevel(level))
				{
					MessageBox.Show("Add new level successfully!");
					levelUserControl.LoadData();
				}
				else
				{
					MessageBox.Show("Error when adding new level!");
				}
			}
			else
			{
				// Cập nhật 
				level.ID = levelUpdate.ID;
				level.Level_Name = levelName;

				if (levelBUS.UpdateLevel(level))
				{
					MessageBox.Show("Update level successfully!");
					levelUserControl.LoadData();
				}
				else
				{
					MessageBox.Show("Error when updating level!");
				}
			}

			this.Close();

		}
	}
}
