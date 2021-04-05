using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DBAccess
	{
		private SqlConnection conn;
		//private SqlConnection connProc;
		private SqlCommand cmd;
		
		//Phương thức lấy chuỗi kết nối

		public SqlConnection open()
		{
			conn = new SqlConnection("Data Source=DESKTOP-PP42M7U;Initial Catalog=QUANLYPHONGTRO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			conn.Open();
			return conn;
		}

		public void close()
		{
			try
			{
				conn.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				throw e;
			}
		}

		//Load dữ liệu không có tham số truyền vào
		public DataTable executeQuery(String sql)
		{
			cmd = new SqlCommand(sql, conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable table = new DataTable();
			adapter.Fill(table);

			return table;
		}

		//Load dữ liệu có tham số truyền vào (tìm kiếm) -  Sử dụng procedure
		public DataTable LayDuLieu(String procName, SqlParameter[] giatri)
		{
			cmd = new SqlCommand(procName, conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddRange(giatri);
			int rowAffected = cmd.ExecuteNonQuery();
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);

			DataTable table = new DataTable();
			adapter.Fill(table);
				
			return table;
		}
		//Hàm update tổng quát(thêm - xóa - sửa) -  Sử dụng procedure
		public bool Update(String procName, SqlParameter[] parameters)
		{
			
			
				cmd = new SqlCommand(procName, conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddRange(parameters);
				int row = cmd.ExecuteNonQuery();

				return (row == 1);
			}
		}
	}
}