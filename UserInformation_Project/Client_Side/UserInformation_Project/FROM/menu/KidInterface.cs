using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;


namespace UserInformation_Project.FROM.menu
{
	public partial class KidInterface : DevExpress.XtraEditors.XtraForm
	{
		DataSet dsmain;
		string kid_key;
		DataSet ds;
		public KidInterface()
		{
			InitializeComponent();
			this.gridView1.RowChangingEvent += gridView1_RowChangingEvent;
			this.simpleButton1.Click += simpleButton1_Click;
			this.simpleButton2.Click += simpleButton2_Click;
			this.simpleButton3.Click += simpleButton3_Click;
		}

		protected override void OnShown(EventArgs e)
		{
			dateEdit1.EditValue = DateTime.Today;
			dateEdit2.EditValue = DateTime.Today;

			DataTable dt_name = UserInformation_Project.UIP.FROM.Uip.ClassRetrieveName().Tables[0];

			foreach (DataRow item in dt_name.AsEnumerable())
			{
				comboBoxEdit1.Properties.Items.Add(item["CLS_NAME"].ToString());
			}

			ds = new DataSet();

			ds = UserInformation_Project.UIP.FROM.Uip.KidRetrieve();
			gridView1.DataBinding(ds.Tables[0]);

			dsmain = UserInformation_Project.UIP.FROM.Uip.KidRetrieveInfo("");
		}

		private void gridView1_RowChangingEvent(DataRow dr)
		{
			dsmain = UserInformation_Project.UIP.FROM.Uip.KidRetrieveInfo(dr["KID_KEY"].ToString());
			DataTable dt = dsmain.Tables[0];
			DataRow row = dt.Rows[0];
			kid_key = row["KID_KEY"].ToString();
			textEdit1.EditValue = row["KID_NAME"].ToString();
			comboBoxEdit1.EditValue = row["CLS_NAME"].ToString();
			textEdit4.EditValue = row["KID_DAD"].ToString();
			textEdit5.EditValue = row["KID_MOM"].ToString();

			dateEdit1.EditValue = Convert.ToDateTime(row["KID_BIRTH"]);
			dateEdit2.EditValue = Convert.ToDateTime(row["KID_REG_DT"]);
			
			textEdit3.EditValue = row["KID_ADD"].ToString();
			textEdit9.EditValue = row["KID_TEL"].ToString();

		}

		#region Button

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			kid_key = System.Guid.NewGuid().ToString();
			textEdit1.EditValue ="";
			comboBoxEdit1.EditValue = "";
			textEdit4.EditValue ="";
			textEdit5.EditValue ="";

			dateEdit1.EditValue = DateTime.Today;
			dateEdit2.EditValue = DateTime.Today;

			textEdit3.EditValue ="";
			textEdit9.EditValue = "010-####-####";
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (kid_key == null) return;
			UserInformation_Project.UIP.FROM.Uip.KidDelete(kid_key);
			Retrieve();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (kid_key != "")
			{
				DataTable dt = dsmain.Tables[0];

				var exist = ds.Tables[0].AsEnumerable().Where(i => i["KID_KEY"].ToString() == kid_key).FirstOrDefault();
				if (exist != null)
				{

					DataRow row = dt.Rows[0];
					row["KID_KEY"] = kid_key;
					row["KID_NAME"] = textEdit1.Text;
					row["CLS_NAME"] = comboBoxEdit1.Text;
					row["KID_DAD"] = textEdit4.Text;
					row["KID_MOM"] = textEdit5.Text;
					row["KID_BIRTH"] = dateEdit1.EditValue.ToString().Substring(0, 10);
					row["KID_REG_DT"] = dateEdit2.EditValue.ToString().Substring(0, 10);
					row["KID_ADD"] = textEdit3.Text;
					row["KID_TEL"] = textEdit9.Text;
				}
				else
				{
					DataRow row = dt.NewRow();
					row["KID_KEY"] = kid_key;
					row["KID_NAME"] = textEdit1.Text;
					row["CLS_NAME"] = comboBoxEdit1.Text;
					row["KID_DAD"] = textEdit4.Text;
					row["KID_MOM"] = textEdit5.Text;
					row["KID_BIRTH"] = dateEdit1.EditValue.ToString().Substring(0, 10);
					row["KID_REG_DT"] = dateEdit2.EditValue.ToString().Substring(0, 10);
					row["KID_ADD"] = textEdit3.Text;
					row["KID_TEL"] = textEdit9.Text;

					dt.Rows.Add(row);
				}

				UserInformation_Project.UIP.FROM.Uip.KidInsert(this.dsmain);
				XtraMessageBox.Show("success!");
				Retrieve();
			}
		}

		#endregion

		private void Retrieve()
		{
			ds = UserInformation_Project.UIP.FROM.Uip.KidRetrieve();
			gridView1.DataBinding(ds.Tables[0]);
			dsmain = UserInformation_Project.UIP.FROM.Uip.KidRetrieveInfo(kid_key);
		}

	}
}