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
        String from = "", to = "";
        double value;
        double cost;
        public CashPayment(double cost)
        {
            InitializeComponent();
            txtCost.Text = cost.ToString();
            this.cost = cost;
        }

        private void rdEuro_CheckedChanged(object sender, EventArgs e)
        {
            from = "Euros";
            lbPay.Text = lbCost.Text = lbCurrency.Text = "EUR";
            createContextForExchange(from);
        }

        private void rdUSD_CheckedChanged(object sender, EventArgs e)
        {
            from = "Dollars";
            lbPay.Text = lbCost.Text = lbCurrency.Text = "USD";
            createContextForExchange(from);
        }

        private void rdVND_CheckedChanged(object sender, EventArgs e)
        {
            lbPay.Text = lbCost.Text = lbCurrency.Text = "VND";
            from = "VND";
            createContextForExchange(from);
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            value = Convert.ToDouble(txtPayment.Text);
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            exchangeToVND();
            if(!rdVND.Checked)
            {
                double tempCost = Double.Parse(txtCost.Text);
                
                double change = value - tempCost;
                txtChangeCurrency.Text = change.ToString();
            }
        }

        public void createContextForExchange(String to)
        {
            String thisFrom = "VND";
            Console.WriteLine(cost + "/" + thisFrom + "/" + to);
            Context context = new Context(cost, thisFrom, to);

            object convertFrom = context.GetInstance("QLNT.VND");
            Type t = convertFrom.GetType();
            double toValue = (Double)t.GetMethod(to.ToLower()).Invoke(convertFrom, new Object[] { context.getValue() });

            txtCost.Text = toValue.ToString();
        }

        private void lbCurrency_Click(object sender, EventArgs e)
        {

        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCost_Click(object sender, EventArgs e)
        {

        }

        public void exchangeToVND()
        {
            String to = "VND";
            Context context = new Context(value, from, to);

            object convertFrom = context.GetInstance("QLNT." + from);
            Type t = convertFrom.GetType();
            double toValue = (Double)t.GetMethod(to.ToLower()).Invoke(convertFrom, new Object[] { context.getValue() });
            double change = toValue - cost;

            txtChange.Text = change.ToString();
        }
    }
}
