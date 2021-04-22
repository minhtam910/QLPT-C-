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
			Application.Run(new Form1(service));
			//Application.Run(new SelectInfo());
		}
	}
}
