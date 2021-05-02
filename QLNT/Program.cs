using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ThongBaoService service = new ThongBaoService();
			List<ThongTinHoaDon> listThongtin = new List<ThongTinHoaDon>();
			Dictionary<string, Object> listObject = new Dictionary<string, object> { };
			listObject = new Dictionary<string, Object>(){ { "DangKy", new DangKy() },
														{"DichVu", new DichVu() },
														{"KhachThue", new KhachThue()}
													 };
			Application.Run(new Form1(service, listThongtin, listObject));
		}
	}
}
