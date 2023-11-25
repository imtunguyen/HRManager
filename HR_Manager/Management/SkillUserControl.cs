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
    public partial class SkillUserControl : UserControl
    {
        SkillsBUS skillsBUS = new SkillsBUS();
        private int idSelected; // id của row được select
        private ComboBox cbID; // Declare ComboBox at the class level
        private TextBox txtSkillsName; // Declare TextBox at the class level
        private TextBox txtDescription; // Declare TextBox for description
        public SkillUserControl()
        {
            InitializeComponent();
            cbID = new ComboBox();
            txtSkillsName = new TextBox();
            txtDescription = new TextBox();
            ConfigureDataGridView();
            LoadData();
        }

        public void LoadData()
        {
            List<Skills> skills = skillsBUS.GetAllSkills();
            dataGridView1.DataSource = skills;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fCRUDSkill frm = new fCRUDSkill(this);
            frm.cbID.SelectedIndexChanged += cbID_SelectedIndexChanged; // Add event handler
            frm.ShowDialog();
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected ID
            int selectedId = Convert.ToInt32(cbID.SelectedItem);

            // Fetch the corresponding Skill Name and Description based on the selected ID
            Skills selectedSkill = skillsBUS.GetSkillById(selectedId);

            // Update the txtSkillsName and txtDescription TextBoxes
            if (selectedSkill != null)
            {
                txtSkillsName.Text = selectedSkill.Skills_Name;
                txtDescription.Text = selectedSkill.description;
            }
            else
            {
                txtSkillsName.Text = string.Empty;
                txtDescription.Text = string.Empty;
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

            // Get the Skills object using the ID
            Skills skill = skillsBUS.GetSkillById(id);

            if (skill == null)
            {
                MessageBox.Show("The item to be edited is not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open the form for editing with the existing Skills data
            fCRUDSkill f = new fCRUDSkill(this, skill);
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
    }
}
