﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class MiGoi:IService
    {
        public void cook(String maKhach, String maPhong)
        {
            MessageBox.Show("Mì gói đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong +"!");
        }
    }
}
