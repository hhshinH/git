using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Services;

namespace WebApplication1
{
	/// <summary>
	/// WS의 요약 설명입니다.
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// ASP.NET AJAX를 사용하여 스크립트에서 이 웹 서비스를 호출하려면 다음 줄의 주석 처리를 제거합니다. 
	// [System.Web.Script.Services.ScriptService]
	public class WS : System.Web.Services.WebService
	{
		#region Kid

		[WebMethod]
		public DataSet KidRetrieve()
		{
			return UserInformation_Project.BIZ.FROM.SP.KidRetrieve();
		}

		[WebMethod]
		public DataSet KidRetrieveInfo(string kid_key)
		{
			return UserInformation_Project.BIZ.FROM.SP.KidRetrieveInfo(kid_key);
		}
				
		[WebMethod]
		public void KidDelete(string kid_key)
		{
			UserInformation_Project.BIZ.FROM.SP.KidDelete(kid_key);
		}

		[WebMethod]
		public void KidInsert(DataSet ds)
		{
			UserInformation_Project.BIZ.FROM.SP.KidInsert(ds.Tables[0].Rows[0]);
		}

		#endregion 

		#region Teach

		[WebMethod]
		public DataSet TeachRetrieve()
		{
			return UserInformation_Project.BIZ.FROM.SP.TeachRetrieve();
		}

		[WebMethod]
		public DataSet TeachRetrieveInfo(string teach_key)
		{
			return UserInformation_Project.BIZ.FROM.SP.TeachRetrieveInfo(teach_key);
		}

		[WebMethod]
		public void TeachDelete(string teach_key)
		{
			UserInformation_Project.BIZ.FROM.SP.TeachDelete(teach_key);
		}

		[WebMethod]
		public void TeachInsert(DataSet ds)
		{
			UserInformation_Project.BIZ.FROM.SP.TeachInsert(ds.Tables[0].Rows[0]);
		}

		#endregion Teach

		#region Class

		[WebMethod]
		public DataSet ClassRetrieve()
		{
			return UserInformation_Project.BIZ.FROM.SP.ClassRetrieve();
		}

		[WebMethod]
		public DataSet ClassDelete(string cls_key)
		{
			return UserInformation_Project.BIZ.FROM.SP.ClassDelete(cls_key);
		}

		[WebMethod]
		public void ClassInsert(DataSet ds)
		{
			foreach (DataRow item in ds.Tables[0].AsEnumerable())
			{
				UserInformation_Project.BIZ.FROM.SP.ClassInsert(item);
			}
		}

		[WebMethod]
		public DataSet ClassRetrieveName()
		{
			return UserInformation_Project.BIZ.FROM.SP.ClassRetrieveName();
		}

		[WebMethod]
		public DataSet ClassKidRetrieve(string cls_key)
		{
			return UserInformation_Project.BIZ.FROM.SP.ClassKidRetrieve(cls_key);
		}

		#endregion

		#region Grid Data

		[WebMethod]
		public DataSet TeachGirdRetrieve()
		{
			return UserInformation_Project.BIZ.FROM.SP.TeachGirdRetrieve();
		}

		#endregion

		#region Attendance

		[WebMethod]
		public DataSet AttendanceRetrieve(string dt_stat, string dt_end)
		{
			return UserInformation_Project.BIZ.FROM.SP.AttendanceRetrieve(dt_stat, dt_end);
		}


		[WebMethod]
		public void AttendanceInsert(string kid_key, string date, string inout)
		{
			UserInformation_Project.BIZ.FROM.SP.AttendanceInsert(kid_key, date, inout);
		}

		#endregion

		#region Drogschedule

		[WebMethod]
		public DataSet DropscheduleRetrieve()
		{
			return UserInformation_Project.BIZ.FROM.SP.DrogscheduleRetrieve();
		}

		[WebMethod]
		public DataSet DropscheduleDelete(string drog_key)
		{
			return UserInformation_Project.BIZ.FROM.SP.DropscheduleDelete(drog_key);
		}

		[WebMethod]
		public void DropscheduleInsert(DataSet ds)
		{
			foreach (DataRow item in ds.Tables[0].AsEnumerable())
			{
				UserInformation_Project.BIZ.FROM.SP.DropscheduleInsert(item);
			}
		}

		#endregion
	}
}
