using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace UserInformation_Project.BIZ.FROM
{
	public class SP
	{
		#region kid
		public static DataSet KidRetrieve()
		{
			String query = "T_KID_R";
			List<SqlParameter> parameter = null;

			parameter = new List<SqlParameter>();
		
			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);

		}

		public static DataSet KidRetrieveInfo(string kid_key)
		{
			String query = "T_KID_R_INFO";
			List<SqlParameter> parameter = null;

			parameter = new List<SqlParameter>();
			parameter.Add(new SqlParameter("@P_KID_KEY", kid_key));

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);
		}

		public static bool KidDelete(string kid_key)
		{
			String query = "T_KID_D";
			List<SqlParameter> parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_KID_KEY", kid_key));

			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}

		public static bool KidInsert(DataRow dr)
		{
			String query = "T_KID_CU";
			List<SqlParameter> parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_KID_KEY"		, dr["KID_KEY"]));
			parameter.Add(new SqlParameter("@P_KID_NAME"	, dr["KID_NAME"]));
			parameter.Add(new SqlParameter("@P_KID_ADD"		, dr["KID_ADD"]));
			parameter.Add(new SqlParameter("@P_KID_REG_DT"	, dr["KID_REG_DT"]));
			parameter.Add(new SqlParameter("@P_KID_BIRTH"	, dr["KID_BIRTH"]));
			parameter.Add(new SqlParameter("@P_KID_TEL"		, dr["KID_TEL"]));
			parameter.Add(new SqlParameter("@P_KID_MOM"		, dr["KID_MOM"]));
			parameter.Add(new SqlParameter("@P_KID_DAD"		, dr["KID_DAD"]));
			parameter.Add(new SqlParameter("@P_KID_MAIL"	, dr["KID_MAIL"]));
			parameter.Add(new SqlParameter("@P_CLS_NAME"	, dr["CLS_NAME"]));
			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}

		#endregion kid

		#region teach

		public static DataSet TeachRetrieve()
		{
			String query = "T_TEACH_R";
			List<SqlParameter> parameter = null;

			parameter = new List<SqlParameter>();

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);

		}

		public static DataSet TeachRetrieveInfo(string teach_key)
		{
			String query = "T_TEACH_R_INFO";
			List<SqlParameter> parameter = null;

			parameter = new List<SqlParameter>();
			parameter.Add(new SqlParameter("@P_TEACH_KEY", teach_key));

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);
		}

		public static bool TeachDelete(string teach_key)
		{
			String query = "T_TEACH_D";
			List<SqlParameter> parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_TEACH_KEY", teach_key));

			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}


		public static bool TeachInsert(DataRow dr)
		{
			String query = "T_TEACH_CU";
			List<SqlParameter> parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_TEACH_KEY"	, dr["TEACH_KEY"]));
			parameter.Add(new SqlParameter("@P_TEACH_NAME"	, dr["TEACH_NAME"]));
			parameter.Add(new SqlParameter("@P_TEACH_BIRTH"	, dr["TEACH_BIRTH"]));
			parameter.Add(new SqlParameter("@P_REG_DT"		, dr["REG_DT"]));
			parameter.Add(new SqlParameter("@P_TEACH_TEL"	, dr["TEACH_TEL"]));

			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}
		#endregion teach

		#region Class

		public static DataSet ClassRetrieve()
		{
			String query = "T_CLS_R";
			List<SqlParameter> parameter = null;

			parameter = new List<SqlParameter>();

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);

		}

		public static DataSet ClassDelete(string cls_key)
		{
			String query = "T_CLS_D";
			List<SqlParameter> parameter = null;
			parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_CLS_KEY", cls_key));

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);

		}

		public static bool ClassInsert(DataRow dr)
		{
			String query = "T_CLS_CU";
			List<SqlParameter> parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_CLS_KEY"	 , dr["CLS_KEY"]));
			parameter.Add(new SqlParameter("@P_CLS_NAME" , dr["CLS_NAME"]));
			parameter.Add(new SqlParameter("@P_TEACH_KEY", dr["TEACH_KEY"]));
			parameter.Add(new SqlParameter("@P_REMARK"	 , dr["REMARK"]));
	
			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}

		public static DataSet ClassRetrieveName()
		{
			String query = "T_CLS_R_NAME";
			List<SqlParameter> parameter = null;

			parameter = new List<SqlParameter>();

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);

		}
		

		#endregion

		#region Class Kid

		public static DataSet ClassKidRetrieve(string cls_key)
		{
			String query = "T_CLS_R_KID";
			List<SqlParameter> parameter = null;
			parameter = new List<SqlParameter>();
			parameter.Add(new SqlParameter("@P_CLS_KEY", cls_key));

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);
		}

		#endregion

		#region Grid Data

		public static DataSet TeachGirdRetrieve()
		{
			String query = "T_GRID_DATA_TEACH";
			List<SqlParameter> parameter = null;
			parameter = new List<SqlParameter>();

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);
		}

		#endregion
		
		#region Attendance

		public static DataSet AttendanceRetrieve(string dt_stat, string dt_end)
		{
			String query = "T_ATT_R";
			List<SqlParameter> parameter = null;
			parameter = new List<SqlParameter>();
			parameter.Add(new SqlParameter("@P_DT_STAT", dt_stat));
			parameter.Add(new SqlParameter("@P_DT_END", dt_end));

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);
		}

		public static bool AttendanceInsert(string kid_key, string date, string inout)
		{
			String query = "T_ATT_CU";
			List<SqlParameter> parameter = new List<SqlParameter>();
			parameter.Add(new SqlParameter("@P_KID_KEY" , kid_key));
			parameter.Add(new SqlParameter("@P_DATE"	, date	));
			parameter.Add(new SqlParameter("@P_INOUT"   , inout));

			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}
		#endregion

		#region Dropschedule

		public static DataSet DrogscheduleRetrieve()
		{
			String query = "T_DROG_R";
			List<SqlParameter> parameter = null;
			parameter = new List<SqlParameter>();

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);
		}

		public static DataSet DropscheduleDelete(string drog_key)
		{
			String query = "T_DROG_D";
			List<SqlParameter> parameter = null;
			parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_DROG_KEY", drog_key));

			return SqlHelper.ExcutedataSet(query, System.Data.CommandType.StoredProcedure, parameter);

		}

		public static bool DropscheduleInsert(DataRow dr)
		{
			String query = "T_DROG_CU";
			List<SqlParameter> parameter = new List<SqlParameter>();

			parameter.Add(new SqlParameter("@P_DROG_KEY"	, dr["DROG_KEY"]));
			parameter.Add(new SqlParameter("@P_TEACH_KEY"	, dr["TEACH_KEY"]));
			parameter.Add(new SqlParameter("@P_KID_KEY"		, dr["KID_KEY"]));
			parameter.Add(new SqlParameter("@P_S_DATE"		, dr["S_DATE"]));
			parameter.Add(new SqlParameter("@P_E_DATE"		, dr["E_DATE"]));
			parameter.Add(new SqlParameter("@P_TIME_O"		, dr["TIME_O"]));
			parameter.Add(new SqlParameter("@P_TIME_T"		, dr["TIME_T"]));
			parameter.Add(new SqlParameter("@P_RMK"			, dr["RMK"]));

			return SqlHelper.ExcuteQuery(query, System.Data.CommandType.StoredProcedure, parameter) >= 0;
		}

		#endregion

	}
}
