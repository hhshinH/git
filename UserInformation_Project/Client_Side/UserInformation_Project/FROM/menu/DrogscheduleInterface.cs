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

namespace UserInformation_Project.FROM.menu
{
	public partial class DrogscheduleInterface : DevExpress.XtraEditors.XtraForm
	{
		DataSet dsmain;
		string drog_key = "";
		public DrogscheduleInterface()
		{
			InitializeComponent();
			this.simpleButton1.Click += simpleButton1_Click;
			this.simpleButton2.Click += simpleButton2_Click;
			this.simpleButton3.Click += simpleButton3_Click;
			this.gridViewDropschedule1.RowChangingEvent += gridViewDropschedule1_RowChangingEvent;
		}

		protected override void OnShown(EventArgs e)
		{
			dsmain = new DataSet();

			dsmain = UserInformation_Project.UIP.FROM.Uip.DropscheduleRetrieve();
			this.gridViewDropschedule1.DataBinding(dsmain.Tables[0]);
		}

		private void gridViewDropschedule1_RowChangingEvent(DataRow dr)
		{
			drog_key = dr["DROG_KEY"].ToString();
		}

		#region Button

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			DataTable dt = this.dsmain.Tables[0];
			DataRow row = dt.NewRow();
			row["DROG_KEY"] = System.Guid.NewGuid().ToString();
			row["RMK"] = "";

			dt.Rows.Add(row);
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			UserInformation_Project.UIP.FROM.Uip.DropscheduleDelete(drog_key);

			var row = this.dsmain.Tables[0].AsEnumerable().Where(i => i["DROG_KEY"].ToString() == drog_key).FirstOrDefault();
			this.dsmain.Tables[0].Rows.Remove(row);
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			UserInformation_Project.UIP.FROM.Uip.DropscheduleInsert(dsmain);
			XtraMessageBox.Show("success!");
		}

		#endregion
	}
}