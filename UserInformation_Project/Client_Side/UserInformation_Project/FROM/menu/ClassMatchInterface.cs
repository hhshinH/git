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
	public partial class ClassMatchInterface : DevExpress.XtraEditors.XtraForm
	{
		DataSet dsmain;
		DataSet dsmain_kid;
		string cls_key = "";
		public ClassMatchInterface()
		{
			InitializeComponent();
			gridViewClass1.RowChangingEvent += gridViewClass1_RowChangingEvent;
			this.simpleButton1.Click += simpleButton1_Click;
			this.simpleButton2.Click += simpleButton2_Click;
			this.simpleButton3.Click += simpleButton3_Click;
		}

		protected override void OnShown(EventArgs e)
		{
			dsmain = new DataSet();

			dsmain = UserInformation_Project.UIP.FROM.Uip.ClassRetrieve();
			gridViewClass1.DataBinding(dsmain.Tables[0]);
		}

		private void gridViewClass1_RowChangingEvent(DataRow dr)
		{
			cls_key = dr["CLS_KEY"].ToString();
			//
			dsmain_kid = new DataSet();
			dsmain_kid = UserInformation_Project.UIP.FROM.Uip.ClassKidRetrieve(cls_key);
			gridViewClassKid1.DataBinding(dsmain_kid.Tables[0]);

		}

		#region button 

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			DataTable dt = this.dsmain.Tables[0];
			DataRow row = dt.NewRow();
			row["CLS_KEY"] = System.Guid.NewGuid().ToString();
			row["CLS_NAME"] ="";
			row["TEACH_KEY"] ="";
			row["REMARK"] = "";

			dt.Rows.Add(row);
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			UserInformation_Project.UIP.FROM.Uip.ClassDelete(cls_key);

			var row = this.dsmain.Tables[0].AsEnumerable().Where(i => i["CLS_KEY"].ToString() == cls_key).FirstOrDefault();
			this.dsmain.Tables[0].Rows.Remove(row);
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			UserInformation_Project.UIP.FROM.Uip.ClassInsert(dsmain);
			XtraMessageBox.Show("success!");
		}

		#endregion
	}
}