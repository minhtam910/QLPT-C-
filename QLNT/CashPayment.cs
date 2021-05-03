using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class CashPayment : Form
    {
        public CashPayment(double cost)
        {
            InitializeComponent();
            txtCost.Text = cost.ToString(); 
        }
    }
}
