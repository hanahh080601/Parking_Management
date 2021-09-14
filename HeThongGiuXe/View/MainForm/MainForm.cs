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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginRequire();

        }
        private void LoginRequire()
        {
            if (!Session.HasUser())
            {
                // Show login form
                LoginForm form = new LoginForm();
                this.Hide();
                form.ShowDialog();
                // Check if login success
                if (!Session.HasUser())
                {
                    System.Environment.Exit(1);
                }
                // Show main if login sucess
                this.lbFullname.Text = Session.GetCurrentUser().fullname;
                HideNotAllowFeature();
                this.Show();
            }
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading.Start(this);
            CheckinForm form = new CheckinForm();
            Loading.Close();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loading.Start(this);
            CheckoutForm form = new CheckoutForm();
            Loading.Close();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnGeneralManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCustomer form = new ManageCustomer();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnParkingManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageVehicle form = new ManageVehicle();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnManageManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployeeForm form = new ManageEmployeeForm();
            form.ShowDialog(this);
            this.Show();
        }

        private void btnUnitPrice_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUnitPrice form = new ManageUnitPrice();
            form.ShowDialog(this);
            this.Show();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveCurrentUser();
            LoginRequire();
        }
        private void HideNotAllowFeature()
        {
            string role = Session.GetCurrentUser().Role.code;
            if (Session.GetCurrentUser() == null) return;
            this.btnCheckin.Enabled = this.btnCheckout.Enabled = role == "employee" ||  role == "admin";
            this.btnParkingManagement.Enabled = role == "employee" || role == "manager" || role == "admin";
            this.btnUnitPrice.Enabled = role == "manager" || role == "admin";
            this.btnGeneralManagement.Enabled = role == "manager" || role == "admin";
            this.btnManageManager.Enabled = role == "admin";
            this.btn_analysis.Enabled = role == "admin" || role == "manager";
            this.btn_payment.Enabled = role == "admin" || role == "manager";
            this.btn_paring_package.Enabled = role == "admin" || role == "manager";

        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalysisRevenueForm form = new AnalysisRevenueForm();
            form.ShowDialog(this);
            this.Show();
        }

        private void btn_paring_package_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingPackageForm form = new ParkingPackageForm();
            form.ShowDialog(this);
            this.Show();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentManagementForm form = new PaymentManagementForm();
            form.ShowDialog(this);
            this.Show();
        }
    }
}
