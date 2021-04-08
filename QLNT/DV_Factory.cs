using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    interface DV_Factory
    {	
		void ThemDichVu(DichVu dv);
        bool SuaDichVu(DichVu dv);
        void XoaDichVu(DichVu dv);
        DataTable LoadDoAn();
    }
	



	}
