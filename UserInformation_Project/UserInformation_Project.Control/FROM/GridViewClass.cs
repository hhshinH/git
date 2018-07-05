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

namespace UserInformation_Project.Control.FROM
{
	public partial class GridViewClass : DevExpress.XtraEditors.XtraUserControl
	{
		public delegate void RowChangingHandler(DataRow dr);
		public event RowChangingHandler RowChangingEvent;

		public GridViewClass()
		{
			InitializeComponent();
			this.gridView1.MouseDown += gridControl1_MouseDown;
		}

		public void DataBinding(DataTable dt)
		{
			this.gridControl1.DataSource = dt;
			GridSetting();
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

		public void GridSetting()
		{
			this.gridView1.Columns["CLS_NAME"].Caption = "반 이름";
			this.gridView1.Columns["TEACH_KEY"].Caption = "담임 선생님";
			this.gridView1.Columns["REMARK"].Caption = "REMARK";
			this.gridView1.Columns["CLS_KEY"].Visible = false;

			RepositoryItem();
		}
		private void RepositoryItem()
		{
			DataTable dt = UserInformation_Project.UIP.FROM.Uip.TeachGirdRetrieve().Tables[0];
			RepositoryItemGridLookUpEdit repository = new RepositoryItemGridLookUpEdit();
			repository.View.PopulateColumns(dt);
			repository.DataSource = dt;
			repository.ValueMember = "TEACH_KEY";
			repository.DisplayMember = "TEACH_NAME";
			repository.NullText = "";

			repository.View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
			repository.PopupFormSize = new Size(100, 100);

			foreach (DataColumn dc in dt.Columns)
				repository.View.Columns[dc.ColumnName].Visible = dc.ColumnName.ToString().Equals("TEACH_NAME");

			repository.View.OptionsView.ShowColumnHeaders = false;
			repository.View.BestFitColumns();

			this.gridView1.Columns["TEACH_KEY"].ColumnEdit = repository;
		}
	}
}
