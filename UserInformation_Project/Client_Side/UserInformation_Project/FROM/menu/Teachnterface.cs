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
	public partial class Teachnterface : DevExpress.XtraEditors.XtraForm
	{
		DataSet dsmain;
		string teach_key;
		DataSet ds;
		public Teachnterface()
		{
			InitializeComponent();
			this.gridViewTeach1.RowChangingEvent += gridViewTeach1_RowChangingEvent;
			this.simpleButton1.Click += simpleButton1_Click;
			this.simpleButton2.Click += simpleButton2_Click;
			this.simpleButton3.Click += simpleButton3_Click;
		}

		protected override void OnShown(EventArgs e)
		{
			dateEdit1.EditValue = DateTime.Today;
			dateEdit2.EditValue = DateTime.Today;

			ds = new DataSet();

			ds = UserInformation_Project.UIP.FROM.Uip.TeachRetrieve();
			gridViewTeach1.DataBinding(ds.Tables[0]);
			dsmain = UserInformation_Project.UIP.FROM.Uip.TeachRetrieveInfo("");
		}


		private void gridViewTeach1_RowChangingEvent(DataRow dr)
		{
			dsmain = UserInformation_Project.UIP.FROM.Uip.TeachRetrieveInfo(dr["TEACH_KEY"].ToString());
			DataTable dt = dsmain.Tables[0];
			DataRow row = dt.Rows[0];
			teach_key = row["TEACH_KEY"].ToString();
			textEdit1.EditValue = row["TEACH_NAME"].ToString();
			textEdit2.EditValue = row["CLS_NAME"].ToString();

			dateEdit1.EditValue = Convert.ToDateTime(row["TEACH_BIRTH"]);
			dateEdit2.EditValue = Convert.ToDateTime(row["REG_DT"]);

			textEdit9.EditValue = row["TEACH_TEL"].ToString();
		}


		#region Button

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			teach_key = System.Guid.NewGuid().ToString();
			textEdit1.EditValue = "";
			textEdit2.EditValue = "";

			dateEdit1.EditValue = DateTime.Today;
			dateEdit2.EditValue = DateTime.Today;
			textEdit9.EditValue = "010-####-####";
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			if (teach_key == null) return;
			UserInformation_Project.UIP.FROM.Uip.TeachDelete(teach_key);
			Retrieve();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			if (teach_key != "")
			{
				DataTable dt = dsmain.Tables[0];

				var exist = ds.Tables[0].AsEnumerable().Where(i => i["TEACH_KEY"].ToString() == teach_key).FirstOrDefault();
				if (exist != null)
				{
					DataRow row = dt.Rows[0];


					row["TEACH_KEY"] = teach_key;
					row["TEACH_NAME"] = textEdit1.Text;
					row["TEACH_BIRTH"] = dateEdit1.EditValue.ToString().Substring(0, 10);
					row["REG_DT"] = dateEdit2.EditValue.ToString().Substring(0, 10);
					row["TEACH_TEL"] = textEdit9.Text;
				}
				else
				{
					DataRow row = dt.NewRow();
					row["TEACH_KEY"] = teach_key;
					row["TEACH_NAME"] = textEdit1.Text;
					row["TEACH_BIRTH"] = dateEdit1.EditValue.ToString().Substring(0, 10);
					row["REG_DT"] = dateEdit2.EditValue.ToString().Substring(0, 10);
					row["TEACH_TEL"] = textEdit9.Text;

					dt.Rows.Add(row);
				}
				UserInformation_Project.UIP.FROM.Uip.TeachInsert(this.dsmain);
				XtraMessageBox.Show("success!");
				Retrieve();
			}
		}

		#endregion

		private void Retrieve()
		{
			ds = UserInformation_Project.UIP.FROM.Uip.TeachRetrieve();
			gridViewTeach1.DataBinding(ds.Tables[0]);
			dsmain = UserInformation_Project.UIP.FROM.Uip.TeachRetrieveInfo(teach_key);
		}
	}
}