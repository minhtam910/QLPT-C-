using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNT
{
    public partial class SelectInfo : Form
    {
        DBAccess manager;
        DangKyBLL dangKyBLL = new DangKyBLL();
        String maPhong;
        ThongBaoService service;
        List<ThongTinHoaDon> listThongTin;

        public SelectInfo(ThongBaoService service, List<ThongTinHoaDon> list)
        {
            InitializeComponent();

            try
            {
                this.service = service;
                listThongTin = list;
                cbPhong.DataSource = dangKyBLL.LoadPhongDaCoKhach();
                cbPhong.DisplayMember = "MaPhong";
                cbPhong.ValueMember = "MaPhong";
                cbPhong.SelectedIndex = 0;
                maPhong = cbPhong.SelectedValue.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            manager = new DBAccess();
            manager.open();

            SqlParameter p1 = new SqlParameter("@maphong", maPhong);
            SqlParameter p2 = new SqlParameter("@code", txtCode.Text);
            SqlParameter[] parameters = { p1, p2 };

            String sql = "select * from PHONG_TRO where MaPhong = @maphong and SoNguoi = @code";

            DataTable dt = manager.Select(sql, parameters);
            if(dt.Rows.Count > 0)
            {
                GuestRoom fgr = new GuestRoom(maPhong,service,listThongTin);
                fgr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai mã xác thực");
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            maPhong = cbPhong.SelectedValue.ToString();
            Console.WriteLine(maPhong);
        }
    }
}
