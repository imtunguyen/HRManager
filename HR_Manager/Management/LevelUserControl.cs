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
	public partial class LevelUserControl : UserControl
	{
		LevelBUS levelBUS = new LevelBUS();
		private int idSelected; // id của row được select
		private ComboBox cbID; // Declare ComboBox at the class level
		private TextBox txtLevel; // Declare TextBox at the class level
		public LevelUserControl()
		{
			InitializeComponent();
			cbID = new ComboBox();
			txtLevel = new TextBox();
			ConfigureDataGridView();
			LoadData();
		}

		public void LoadData()
		{
			List<Level> levels = levelBUS.GetAllLevels();
			dataGridView1.DataSource = levels;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			fCRUDLevel frm = new fCRUDLevel(this);
			frm.cbID.SelectedIndexChanged += cbID_SelectedIndexChanged; // Add event handler
			frm.ShowDialog();

		}
		private void cbID_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Get the selected ID
			int selectedId = Convert.ToInt32(cbID.SelectedItem);

			// Fetch the corresponding Level Name based on the selected ID
			Level selectedLevel = levelBUS.GetLevelById(selectedId);

			// Update the txtLevel TextBox
			if (selectedLevel != null)
			{
				txtLevel.Text = selectedLevel.Level_Name;
			}
			else
			{
				txtLevel.Text = string.Empty;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			// Check if a row is selected
			if (dataGridView1.SelectedRows.Count == 0)
			{
				MessageBox.Show("Please select a row to edit", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Get the selected row's index
			int selectedIndex = dataGridView1.SelectedRows[0].Index;

			// Get the ID from the selected row
			int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

			// Get the Level object using the ID
			Level l = levelBUS.GetLevelById(id);

			if (l == null)
			{
				MessageBox.Show("The item to be edited is not found", SD.tb, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Increment the ID value before passing it to the fCRUDLevel form

			// Open the form for editing with the incremented ID
			fCRUDLevel f = new fCRUDLevel(this, l);
			f.ShowDialog();
		}

		private void ConfigureDataGridView()
		{
			// Set the column autosize mode to fill
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			// Set the row autosize mode to all cells
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

			// Set the row height to automatically adjust based on the content
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			// Set the column fill weight to distribute the available space among columns
			foreach (DataGridViewColumn column in dataGridView1.Columns)
			{
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				column.FillWeight = 1; // You can adjust this value based on your preference
			}
		}



		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
