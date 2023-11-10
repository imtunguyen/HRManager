namespace HR_Manager.Payroll
{
	partial class ContractUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			gbStatus = new GroupBox();
			rbCancelled = new RadioButton();
			rbExpired = new RadioButton();
			rbRunning = new RadioButton();
			rbNew = new RadioButton();
			rbAll = new RadioButton();
			btnThemContract = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			gbStatus.SuspendLayout();
			SuspendLayout();
			// 
			// gbStatus
			// 
			gbStatus.BackgroundImageLayout = ImageLayout.None;
			gbStatus.Controls.Add(rbCancelled);
			gbStatus.Controls.Add(rbExpired);
			gbStatus.Controls.Add(rbRunning);
			gbStatus.Controls.Add(rbNew);
			gbStatus.Controls.Add(rbAll);
			gbStatus.Cursor = Cursors.Hand;
			gbStatus.FlatStyle = FlatStyle.Flat;
			gbStatus.Location = new Point(12, 51);
			gbStatus.Name = "gbStatus";
			gbStatus.Size = new Size(403, 44);
			gbStatus.TabIndex = 5;
			gbStatus.TabStop = false;
			// 
			// rbCancelled
			// 
			rbCancelled.AutoSize = true;
			rbCancelled.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbCancelled.ForeColor = Color.FromArgb(242, 78, 29);
			rbCancelled.Location = new Point(311, 14);
			rbCancelled.Name = "rbCancelled";
			rbCancelled.Size = new Size(96, 24);
			rbCancelled.TabIndex = 0;
			rbCancelled.TabStop = true;
			rbCancelled.Text = "Cancelled";
			rbCancelled.UseVisualStyleBackColor = true;
			// 
			// rbExpired
			// 
			rbExpired.AutoSize = true;
			rbExpired.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbExpired.ForeColor = Color.FromArgb(255, 172, 0);
			rbExpired.Location = new Point(216, 14);
			rbExpired.Name = "rbExpired";
			rbExpired.Size = new Size(82, 24);
			rbExpired.TabIndex = 0;
			rbExpired.TabStop = true;
			rbExpired.Text = "Expired";
			rbExpired.UseVisualStyleBackColor = true;
			// 
			// rbRunning
			// 
			rbRunning.AutoSize = true;
			rbRunning.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbRunning.ForeColor = Color.FromArgb(40, 167, 69);
			rbRunning.Location = new Point(126, 14);
			rbRunning.Name = "rbRunning";
			rbRunning.Size = new Size(89, 24);
			rbRunning.TabIndex = 0;
			rbRunning.TabStop = true;
			rbRunning.Text = "Running";
			rbRunning.UseVisualStyleBackColor = true;
			// 
			// rbNew
			// 
			rbNew.AutoSize = true;
			rbNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbNew.ForeColor = Color.FromArgb(20, 162, 184);
			rbNew.Location = new Point(60, 14);
			rbNew.Name = "rbNew";
			rbNew.Size = new Size(62, 24);
			rbNew.TabIndex = 0;
			rbNew.TabStop = true;
			rbNew.Text = "New";
			rbNew.UseVisualStyleBackColor = true;
			// 
			// rbAll
			// 
			rbAll.AutoSize = true;
			rbAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			rbAll.Location = new Point(6, 14);
			rbAll.Name = "rbAll";
			rbAll.Size = new Size(49, 24);
			rbAll.TabIndex = 0;
			rbAll.TabStop = true;
			rbAll.Text = "All";
			rbAll.UseVisualStyleBackColor = true;
			// 
			// btnThemContract
			// 
			btnThemContract.BackColor = Color.FromArgb(1, 107, 112);
			btnThemContract.Cursor = Cursors.Hand;
			btnThemContract.FlatStyle = FlatStyle.Flat;
			btnThemContract.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnThemContract.ForeColor = Color.White;
			btnThemContract.Location = new Point(12, 12);
			btnThemContract.Name = "btnThemContract";
			btnThemContract.Size = new Size(79, 33);
			btnThemContract.TabIndex = 4;
			btnThemContract.Text = "New";
			btnThemContract.UseVisualStyleBackColor = false;
			btnThemContract.Click += btnThemContract_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = Color.FromArgb(246, 247, 250);
			flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
			flowLayoutPanel1.Cursor = Cursors.IBeam;
			flowLayoutPanel1.Location = new Point(12, 102);
			flowLayoutPanel1.Margin = new Padding(0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(1111, 584);
			flowLayoutPanel1.TabIndex = 3;
			// 
			// ContractUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(gbStatus);
			Controls.Add(btnThemContract);
			Controls.Add(flowLayoutPanel1);
			Name = "ContractUserControl";
			Size = new Size(1135, 717);
			gbStatus.ResumeLayout(false);
			gbStatus.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox gbStatus;
		private RadioButton rbCancelled;
		private RadioButton rbExpired;
		private RadioButton rbRunning;
		private RadioButton rbNew;
		private RadioButton rbAll;
		private Button btnThemContract;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}
