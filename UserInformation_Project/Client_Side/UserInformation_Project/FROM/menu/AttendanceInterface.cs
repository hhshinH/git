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
	public partial class AttendanceInterface : DevExpress.XtraEditors.XtraForm
	{
		DataSet dsmain;
		public AttendanceInterface()
		{
			InitializeComponent();
			this.dateEdit1.EditValueChanged += dateEdit1_EditValueChanged;
			this.dateEdit2.EditValueChanged += dateEdit2_EditValueChanged;
			this.gridViewAttendance1.RowChangingEvent += gridViewAttendance1_RowChangingEvent;
		}

		protected override void OnShown(EventArgs e)
		{
			dsmain = new DataSet();

			dsmain = UserInformation_Project.UIP.FROM.Uip.AttendanceRetrieve(this.dateEdit1.EditValue==null?"": this.dateEdit1.EditValue.ToString().Substring(0,10), 
																			 this.dateEdit2.EditValue==null?"":	this.dateEdit2.EditValue.ToString().Substring(0,10));
			gridViewAttendance1.DataBinding(dsmain.Tables[0]);
		}


		private void dateEdit1_EditValueChanged(object sender, EventArgs e)
		{

			dsmain = UserInformation_Project.UIP.FROM.Uip.AttendanceRetrieve(this.dateEdit1.EditValue == null ? "" : this.dateEdit1.EditValue.ToString().Substring(0, 10),
																			 this.dateEdit2.EditValue == null ? "" : this.dateEdit2.EditValue.ToString().Substring(0, 10));
			gridViewAttendance1.DataBinding(dsmain.Tables[0]);
		}

		private void dateEdit2_EditValueChanged(object sender, EventArgs e)
		{

			dsmain = UserInformation_Project.UIP.FROM.Uip.AttendanceRetrieve(this.dateEdit1.EditValue == null ? "" : this.dateEdit1.EditValue.ToString().Substring(0, 10),
																			 this.dateEdit2.EditValue == null ? "" : this.dateEdit2.EditValue.ToString().Substring(0, 10));
			gridViewAttendance1.DataBinding(dsmain.Tables[0]);
		}

		private void gridViewAttendance1_RowChangingEvent(DataRow dr, string txt)
		{
			if (dr[txt].ToString() == "클릭")
			{
				MessageBox.Show(string.Format("현재 카카오톡 미연동으로\n [{0}]어린이의 {1}번호로\n 메시지를 전송할수 없습니다", dr["KID_NAME"].ToString(), dr["KID_TEL"].ToString()));

				UserInformation_Project.UIP.FROM.Uip.AttendanceInsert(dr["KID_KEY"].ToString(), dr["DATE"].ToString(), txt);
				dr[txt] = "완료";
			}
		}

	}
}