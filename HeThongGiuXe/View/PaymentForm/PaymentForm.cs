using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.BLL;
using HeThongGiuXe.DAL;
using HeThongGiuXe.Utils;

namespace HeThongGiuXe.View
{
    public partial class PaymentForm : Form
    {
        public PaymentForm(int price, bool canDebit)
        {
            InitializeComponent();
            this.txtPrice.Text = price.ToString() + " vnd";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
