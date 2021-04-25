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
			Application.Run(new Form1(service, listThongtin));
			//Application.Run(new SelectInfo());
		}
	}
}
