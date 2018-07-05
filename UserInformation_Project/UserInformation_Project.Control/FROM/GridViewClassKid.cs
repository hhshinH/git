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

namespace UserInformation_Project.Control.FROM
{
	public partial class GridViewClassKid : DevExpress.XtraEditors.XtraUserControl
	{
		public GridViewClassKid()
		{
			InitializeComponent();

		}

		public void DataBinding(DataTable dt)
		{
			this.gridControl1.DataSource = dt;
			GridSetting();
		}

		public void GridSetting()
		{
			this.gridView1.Columns["CLS_NAME"].Caption = "원아반";
			this.gridView1.Columns["KID_NAME"].Caption = "원아 이름";
		}
	}
}
