namespace UserInformation_Project.FROM.menu
{
	partial class DrogscheduleInterface
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
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.gridViewDropschedule1 = new UserInformation_Project.Control.FROM.GridViewDrogschedule();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
			this.panelControl2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.simpleButton3);
			this.panelControl1.Controls.Add(this.simpleButton2);
			this.panelControl1.Controls.Add(this.simpleButton1);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(906, 29);
			this.panelControl1.TabIndex = 0;
			// 
			// panelControl2
			// 
			this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl2.Controls.Add(this.gridViewDropschedule1);
			this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelControl2.Location = new System.Drawing.Point(0, 29);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Padding = new System.Windows.Forms.Padding(3);
			this.panelControl2.Size = new System.Drawing.Size(906, 501);
			this.panelControl2.TabIndex = 1;
			// 
			// simpleButton3
			// 
			this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton3.Location = new System.Drawing.Point(666, 3);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(75, 23);
			this.simpleButton3.TabIndex = 9;
			this.simpleButton3.Text = "추가";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton2.Location = new System.Drawing.Point(828, 3);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(75, 23);
			this.simpleButton2.TabIndex = 8;
			this.simpleButton2.Text = "삭제";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButton1.Location = new System.Drawing.Point(747, 3);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 7;
			this.simpleButton1.Text = "저장";
			// 
			// gridViewDropschedule1
			// 
			this.gridViewDropschedule1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridViewDropschedule1.Location = new System.Drawing.Point(3, 3);
			this.gridViewDropschedule1.Name = "gridViewDropschedule1";
			this.gridViewDropschedule1.Size = new System.Drawing.Size(900, 495);
			this.gridViewDropschedule1.TabIndex = 0;
			// 
			// DropscheduleInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(906, 530);
			this.Controls.Add(this.panelControl2);
			this.Controls.Add(this.panelControl1);
			this.Name = "DropscheduleInterface";
			this.Text = "DropscheduleInterface";
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.PanelControl panelControl2;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private Control.FROM.GridViewDrogschedule gridViewDropschedule1;
	}
}