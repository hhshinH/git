namespace UserInformation_Project.FROM.menu
{
	partial class AttendanceInterface
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
			this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.gridViewAttendance1 = new UserInformation_Project.Control.FROM.GridViewAttendance();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Location = new System.Drawing.Point(664, 12);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(44, 14);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "기간 설정";
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.dateEdit2);
			this.panelControl1.Controls.Add(this.dateEdit1);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(986, 40);
			this.panelControl1.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl2.Location = new System.Drawing.Point(845, 12);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(9, 14);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "~";
			// 
			// dateEdit2
			// 
			this.dateEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateEdit2.EditValue = null;
			this.dateEdit2.Location = new System.Drawing.Point(860, 9);
			this.dateEdit2.Name = "dateEdit2";
			this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit2.Size = new System.Drawing.Size(114, 20);
			this.dateEdit2.TabIndex = 4;
			// 
			// dateEdit1
			// 
			this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateEdit1.EditValue = null;
			this.dateEdit1.Location = new System.Drawing.Point(725, 9);
			this.dateEdit1.Name = "dateEdit1";
			this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dateEdit1.Size = new System.Drawing.Size(114, 20);
			this.dateEdit1.TabIndex = 3;
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.gridViewAttendance1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl2.Location = new System.Drawing.Point(0, 40);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Padding = new System.Windows.Forms.Padding(3);
			this.panelControl2.Size = new System.Drawing.Size(986, 488);
			this.panelControl2.TabIndex = 4;
			// 
			// gridViewAttendance1
			// 
			this.gridViewAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridViewAttendance1.Location = new System.Drawing.Point(3, 3);
			this.gridViewAttendance1.Name = "gridViewAttendance1";
			this.gridViewAttendance1.Size = new System.Drawing.Size(980, 482);
			this.gridViewAttendance1.TabIndex = 0;
			// 
			// AttendanceInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(986, 528);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.Name = "AttendanceInterface";
			this.Text = "AttendanceInterface";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.DateEdit dateEdit2;
		private DevExpress.XtraEditors.DateEdit dateEdit1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private Control.FROM.GridViewAttendance gridViewAttendance1;
	}
}