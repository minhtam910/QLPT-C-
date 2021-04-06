using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			conn = new SqlConnection("Data Source=.;Initial Catalog=QUANLYPHONGTRO;Integrated Security=True");
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

		public void Insert(String insertStatement, SqlParameter[] parameters)
        {
			try
            {
				cmd = new SqlCommand(insertStatement, conn);
				cmd.Parameters.AddRange(parameters);
				cmd.ExecuteNonQuery();
            }
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message.ToString());
            }
        }

		public void Delete(String deleteStatement, SqlParameter[] parameters)
		{
			try
			{
				cmd = new SqlCommand(deleteStatement, conn);
				cmd.Parameters.AddRange(parameters);
				cmd.ExecuteNonQuery();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
		}

		public DataTable Select(String selectStatement, SqlParameter[] parameters)
		{
			DataTable table = new DataTable();
			try
            {
				cmd = new SqlCommand(selectStatement, conn);
				cmd.Parameters.AddRange(parameters);
				/*int rowNum = cmd.ExecuteNonQuery();
				if (rowNum <= 0)
					MessageBox.Show("Khong co ket qua!");*/

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);

				adapter.Fill(table);
				

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString());
			}
			return table;
		}
	}
}
