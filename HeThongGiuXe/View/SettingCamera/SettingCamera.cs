using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.BLL;
using HeThongGiuXe.DAL;
using HeThongGiuXe.Utils;

namespace HeThongGiuXe.View
{
    public partial class SettingCamera : Form
    {
        public delegate void DelegateAfterOK(string cam);
        private DelegateAfterOK actionAfterOK;
        public SettingCamera(DelegateAfterOK actionAfterOK)
        {
            InitializeComponent();
            this.actionAfterOK = actionAfterOK;
        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.actionAfterOK(this.txtCamera.Text);
            this.Dispose();
        }
    }
}
