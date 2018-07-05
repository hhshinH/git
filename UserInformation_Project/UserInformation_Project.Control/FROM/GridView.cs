using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils.Menu;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;

namespace UserInformation_Project.Control.FROM
{
	public partial class GridView : DevExpress.XtraEditors.XtraUserControl
	{
		public delegate void RowChangingHandler(DataRow dr);
		public event RowChangingHandler RowChangingEvent;

		public GridView()
		{
			InitializeComponent();
			this.gridView1.MouseDown += gridControl1_MouseDown;
		}

		private void gridControl1_MouseDown(object sender, MouseEventArgs e)
		{
			GridHitInfo hint = this.gridView1.CalcHitInfo(e.X, e.Y);

			if (!hint.InGroupRow &&
			   !hint.InColumn &&
			   !hint.InRow) return;

			int rowhandle = hint.RowHandle;

			this.gridView1.FocusedRowHandle = rowhandle;
			DataRow dr = this.gridView1.GetFocusedDataRow();
			RowChangingEvent(dr);
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
			this.gridView1.Columns["KID_BIRTH"].Caption = "생년월일";
			this.gridView1.Columns["KID_BIRTH"].OptionsColumn.ReadOnly = true;
			this.gridView1.Columns["KID_KEY"].Visible = false;

		}

	}
}
