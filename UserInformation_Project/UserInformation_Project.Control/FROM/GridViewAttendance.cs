using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace UserInformation_Project.Control.FROM
{
	public partial class GridViewAttendance : DevExpress.XtraEditors.XtraUserControl
	{
		public delegate void RowChangingHandler(DataRow dr, string txt);
		public event RowChangingHandler RowChangingEvent;

		public GridViewAttendance()
		{
			InitializeComponent();
			this.gridView1.MouseDown += gridView1_MouseDown;
		}

		public void DataBinding(DataTable dt)
		{
			this.gridControl1.DataSource = dt;
			GridSetting();
		}

		public void GridSetting()
		{
			this.gridView1.Columns["KID_NAME"].Caption = "이름";
			this.gridView1.Columns["KID_NAME"].OptionsColumn.ReadOnly = true;
			this.gridView1.Columns["DATE"].Caption = "날짜";
			this.gridView1.Columns["DATE"].OptionsColumn.ReadOnly = true;
			this.gridView1.Columns["IN"].Caption = "등원시간";
			this.gridView1.Columns["IN"].OptionsColumn.ReadOnly = true;
			this.gridView1.Columns["OUT"].Caption = "하원시간";
			this.gridView1.Columns["OUT"].OptionsColumn.ReadOnly = true;
			this.gridView1.Columns["TEACH_NAME"].Caption = "선생님";
			this.gridView1.Columns["TEACH_NAME"].OptionsColumn.ReadOnly = true;

			
			this.gridView1.Columns["KID_KEY"].Visible = false;
			this.gridView1.Columns["KID_TEL"].Visible = false;
		}


		private void gridView1_MouseDown(object sender, MouseEventArgs e)
		{
			GridHitInfo hint = this.gridView1.CalcHitInfo(e.X, e.Y);
			if (!hint.InGroupRow &&
				!hint.InColumn &&
				!hint.InRow) return;
			if (hint.Column == null) return;


			if (!hint.Column.FieldName.Equals("IN") &&
				!hint.Column.FieldName.Equals("OUT")) return;

			int rowhandle = hint.RowHandle;

			if (rowhandle < 0) return;

			this.gridView1.FocusedRowHandle = rowhandle;

			string txt = hint.Column.FieldName.Equals("IN") ? "IN" : "OUT";

			DataRow dr = this.gridView1.GetFocusedDataRow();
			RowChangingEvent(dr, txt);
		}

	}
}
