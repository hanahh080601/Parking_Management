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
    public partial class SerialSettingForm : Form
    {
        private DelegateClickOK ActionClickOK;
        public SerialSettingForm(DelegateClickOK actionClickOK)
        {
            InitializeComponent();
            InitializeData();
            this.ActionClickOK = actionClickOK;
        }
        private void InitializeData()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            this.cbPorts.Items.AddRange(ports);
            if (ports.Length == 0)
            {
                MessageBox.Show("Không tìm thấy cổng Serial nào", "Lỗi thiết bị");
            } else
            {
                this.cbPorts.SelectedIndex = 0;
                this.txtBaund.Text = "9600";
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string port = this.cbPorts.Text;
            if (port == "")
            {
                this.Dispose();
            }
            int baund;
            try
            {
                baund = Convert.ToInt32(this.txtBaund.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show("Baund không hợp lệ", "Lỗi thông tin");
                return;
            }

            ActionClickOK(port, baund);
            this.Dispose();
            

        }
        public delegate void DelegateClickOK(string port, int baund);
    }
}
