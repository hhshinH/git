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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace UserInformation_Project.Control.FROM
{
	public partial class GridViewDrogschedule : DevExpress.XtraEditors.XtraUserControl
	{
		public delegate void RowChangingHandler(DataRow dr);
		public event RowChangingHandler RowChangingEvent;
		public GridViewDrogschedule()
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

		private void GridSetting()
		{
			this.gridView1.Columns["KID_KEY"].Caption = "원아명";
			this.gridView1.Columns["TEACH_KEY"].Caption = "당담교사";
			this.gridView1.Columns["S_DATE"].Caption = "기간";
			this.gridView1.Columns["E_DATE"].Caption = "기간";

			this.gridView1.Columns["TIME_O"].Caption = "투약 시간1";
			this.gridView1.Columns["TIME_T"].Caption = "투약 시간2";
			this.gridView1.Columns["RMK"].Caption = "REMARK";

			this.gridView1.Columns["DROG_KEY"].Visible = false;

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


			DataTable dt2 = UserInformation_Project.UIP.FROM.Uip.KidRetrieve().Tables[0];
			RepositoryItemGridLookUpEdit repository2 = new RepositoryItemGridLookUpEdit();
			repository2.View.PopulateColumns(dt2);
			repository2.DataSource = dt2;
			repository2.ValueMember = "KID_KEY";
			repository2.DisplayMember = "KID_NAME";
			repository2.NullText = "";

			repository2.View.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
			repository2.PopupFormSize = new Size(100, 100);

			foreach (DataColumn dc in dt2.Columns)
				repository2.View.Columns[dc.ColumnName].Visible = dc.ColumnName.ToString().Equals("KID_NAME");

			repository2.View.OptionsView.ShowColumnHeaders = false;
			repository2.View.BestFitColumns();

			this.gridView1.Columns["KID_KEY"].ColumnEdit = repository2;
		}

	}
}
