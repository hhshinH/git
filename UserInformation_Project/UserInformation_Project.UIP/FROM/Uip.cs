using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace UserInformation_Project.UIP.FROM
{
	public class Uip
	{
		#region Kid
		private static WS.WSSoapClient CreateInstance()
		{
			return new WS.WSSoapClient(new System.ServiceModel.BasicHttpBinding(), new System.ServiceModel.EndpointAddress("http://localhost:64751/WS.asmx"));
		}

		public static DataSet KidRetrieve()
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.KidRetrieve();
			}
		}

		public static DataSet KidRetrieveInfo(string kid_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.KidRetrieveInfo(kid_key);
			}
		}

		public static void KidDelete(string kid_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.KidDelete(kid_key);
			}
		}

		public static void KidInsert(DataSet ds)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.KidInsert(ds);
			}
		}

		#endregion 

		#region teach

		public static DataSet TeachRetrieve()
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.TeachRetrieve();
			}
		}

		public static DataSet TeachRetrieveInfo(string kid_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.TeachRetrieveInfo(kid_key);
			}
		}

		public static void TeachDelete(string kid_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.TeachDelete(kid_key);
			}
		}

		public static void TeachInsert(DataSet ds)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.TeachInsert(ds);
			}
		}

		#endregion

		#region Class

		public static DataSet ClassRetrieve()
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.ClassRetrieve();
			}
		}

		public static DataSet ClassDelete(string cls_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.ClassDelete(cls_key);
			}
		}

		public static void ClassInsert(DataSet ds)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.ClassInsert(ds);
			}
		}


		public static DataSet ClassRetrieveName()
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.ClassRetrieveName();
			}
		}

		public static DataSet ClassKidRetrieve(string cls_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.ClassKidRetrieve(cls_key);
			}
		}

		#endregion

		#region Grid Data

		public static DataSet TeachGirdRetrieve()
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.TeachGirdRetrieve();
			}
		}

		#endregion

		#region Attendance

		public static DataSet AttendanceRetrieve(string dt_stat, string dt_end)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.AttendanceRetrieve(dt_stat, dt_end);
			}
		}

		public static void AttendanceInsert(string kid_key, string date, string inout)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.AttendanceInsert(kid_key, date, inout);
			}
		}
		
		#endregion

		#region Drogschedule

		public static DataSet DropscheduleRetrieve()
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.DropscheduleRetrieve();
			}
		}

		public static DataSet DropscheduleDelete(string drog_key)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				return ws.DropscheduleDelete(drog_key);
			}
		}

		public static void DropscheduleInsert(DataSet ds)
		{
			using (WS.WSSoapClient ws = CreateInstance())
			{
				ws.DropscheduleInsert(ds);
			}
		}
		
		#endregion
	}
}
