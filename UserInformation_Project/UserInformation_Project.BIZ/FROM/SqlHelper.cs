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
	public class SqlHelper : IDisposable
	{
		private SqlConnection Conn = null;
		private SqlCommand Cmd = null;
		private SqlDataAdapter dataAdapter = null;

		private readonly string ConnectionString = @"server=fant.iptime.org; uid = hhshin; password =huen3549; database =HHSHIN";

		SqlHelper()
		{
			Conn = new SqlConnection(this.ConnectionString);
			Conn.Open();
		}

		public static int ExcuteQuery(string query, CommandType cmdType, List<SqlParameter> parameter)
		{
			using (SqlHelper helper = new SqlHelper())
			{
				return helper.excuteQuery(query, cmdType, parameter);
			}
		}

		private int excuteQuery(string query, CommandType cmdType, List<SqlParameter> parameter)
		{
			if (this.Isconnected)
			{
				Cmd = new SqlCommand(query, this.Conn);
				Cmd.CommandType = cmdType;
				if (parameter != null && parameter.Count > 0)
				{
					Cmd.Parameters.AddRange(parameter.ToArray());  //?
				}
				return Cmd.ExecuteNonQuery();
			}
			return -1;
		}

		private bool Isconnected
		{
			get
			{
				if (Conn == null)
					return false;
				if (Conn.State == System.Data.ConnectionState.Open)
					return true;

				return false;
			}
		}

		public static DataSet ExcutedataSet(string query, CommandType cmdType, List<SqlParameter> parameter)
		{
			using (SqlHelper helper = new SqlHelper())
			{
				return helper.excutedataSet(query, cmdType, parameter);
			}
		}

		private DataSet excutedataSet(string query, CommandType cmdType, List<SqlParameter> parameter)
		{
			dataAdapter = new SqlDataAdapter(query, this.Conn);
			if (parameter != null && parameter.Count > 0)
			{
				dataAdapter.SelectCommand.Parameters.AddRange(parameter.ToArray());
			}
			dataAdapter.SelectCommand.CommandType = cmdType;

			DataSet ds = new DataSet();
			dataAdapter.Fill(ds);

			return ds;

		}

		public void Dispose()
		{
			try
			{
				Conn.Close();
			}
			catch
			{

			}
			Conn = null;
			dataAdapter = null;
			Cmd = null;
		}
	}
}
