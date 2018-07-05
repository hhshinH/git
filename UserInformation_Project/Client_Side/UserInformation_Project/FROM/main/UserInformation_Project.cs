using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UserInformation_Project.FROM.main
{
	public partial class UserInformation_Project : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public UserInformation_Project()
		{
			InitializeComponent();
			this.barButtonItem1.ItemClick+=barButtonItem1_ItemClick;
			this.barButtonItem2.ItemClick += barButtonItem2_ItemClick;
			this.barButtonItem3.ItemClick += barButtonItem3_ItemClick;
			this.barButtonItem4.ItemClick += barButtonItem4_ItemClick;
			this.barButtonItem5.ItemClick += barButtonItem5_ItemClick;
			this.barButtonItem6.ItemClick += barButtonItem6_ItemClick;
			this.documentManager1.DocumentActivate += delegate(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
			{
				if (this.ActiveMdiChild == null) return;
				DevExpress.XtraEditors.XtraForm frm = (DevExpress.XtraEditors.XtraForm)this.ActiveMdiChild;

			};

		}

		public static object GetInstance(string sAssmebly, string sClass)
		{
			string sUrl = "";
			sUrl = System.IO.Path.Combine(Application.StartupPath, sAssmebly);

			System.Runtime.Remoting.ObjectHandle handle = Activator.CreateInstanceFrom(sUrl, sClass);

			object obj = handle.Unwrap();

			return obj;
		}

		#region Button

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var ExistsForm = this.MdiChildren.Where(i => i.Name.Equals("KID")).FirstOrDefault();
			XtraForm frm;

			if (ExistsForm == null)
			{
				object obj = GetInstance("UserInformation_Project.exe", "UserInformation_Project.FROM.menu.KidInterface");

				frm = (XtraForm)obj;
				frm.Tag = "어린이 관리";
				frm.Text = "어린이 관리";
				frm.Name = "KID";
				frm.WindowState = FormWindowState.Maximized;
				frm.Shown += delegate { };
				frm.MdiParent = this;
				frm.Show();
			}
			else
			{
				frm = (XtraForm)ExistsForm;
				frm.Activate();
			}
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var ExistsForm = this.MdiChildren.Where(i => i.Name.Equals("TEACHER")).FirstOrDefault();
			XtraForm frm;
			if (ExistsForm == null)
			{
				object obj = GetInstance("UserInformation_Project.exe", "UserInformation_Project.FROM.menu.Teachnterface");

				frm = (XtraForm)obj;
				frm.Tag = "선생님 관리";
				frm.Text = "선생님 관리";
				frm.Name = "TEACHER";
				frm.WindowState = FormWindowState.Maximized;
				frm.Shown += delegate { };
				frm.MdiParent = this;
				frm.Show();
			}
			else
			{
				frm = (XtraForm)ExistsForm;
				frm.Activate();
			}
		}

		private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var ExistsForm = this.MdiChildren.Where(i => i.Name.Equals("CLASS")).FirstOrDefault();
			XtraForm frm;
			if (ExistsForm == null)
			{
				object obj = GetInstance("UserInformation_Project.exe", "UserInformation_Project.FROM.menu.ClassMatchInterface");

				frm = (XtraForm)obj;
				frm.Tag = "원아반 관리";
				frm.Text = "원아반 관리";
				frm.Name = "CLASS";
				frm.WindowState = FormWindowState.Maximized;
				frm.Shown += delegate { };
				frm.MdiParent = this;
				frm.Show();
			}
			else
			{
				frm = (XtraForm)ExistsForm;
				frm.Activate();
			}
		}

		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var ExistsForm = this.MdiChildren.Where(i => i.Name.Equals("ATTENDANCE")).FirstOrDefault();
			XtraForm frm;
			if (ExistsForm == null)
			{
				object obj = GetInstance("UserInformation_Project.exe", "UserInformation_Project.FROM.menu.AttendanceInterface");

				frm = (XtraForm)obj;
				frm.Tag = "등하원 관리";
				frm.Text = "등하원 관리";
				frm.Name = "ATTENDANCE";
				frm.WindowState = FormWindowState.Maximized;
				frm.Shown += delegate { };
				frm.MdiParent = this;
				frm.Show();
			}
			else
			{
				frm = (XtraForm)ExistsForm;
				frm.Activate();
			}
		}

		private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var ExistsForm = this.MdiChildren.Where(i => i.Name.Equals("CALENDAR")).FirstOrDefault();
			XtraForm frm;
			if (ExistsForm == null)
			{
				object obj = GetInstance("UserInformation_Project.exe", "UserInformation_Project.FROM.menu.CalendarInterface");

				frm = (XtraForm)obj;
				frm.Tag = "일정표";
				frm.Text = "일정표";
				frm.Name = "CALENDAR";
				frm.WindowState = FormWindowState.Maximized;
				frm.Shown += delegate { };
				frm.MdiParent = this;
				frm.Show();
			}
			else
			{
				frm = (XtraForm)ExistsForm;
				frm.Activate();
			}
		}

		private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var ExistsForm = this.MdiChildren.Where(i => i.Name.Equals("DROG")).FirstOrDefault();
			XtraForm frm;
			if (ExistsForm == null)
			{
				object obj = GetInstance("UserInformation_Project.exe", "UserInformation_Project.FROM.menu.DrogscheduleInterface");

				frm = (XtraForm)obj;
				frm.Tag = "투약 관리";
				frm.Text = "투약 관리";
				frm.Name = "DROG";
				frm.WindowState = FormWindowState.Maximized;
				frm.Shown += delegate { };
				frm.MdiParent = this;
				frm.Show();
			}
			else
			{
				frm = (XtraForm)ExistsForm;
				frm.Activate();
			}
		}

		#endregion
	}
}