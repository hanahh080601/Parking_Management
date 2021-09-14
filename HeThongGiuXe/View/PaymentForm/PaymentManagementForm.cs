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

namespace HeThongGiuXe.View
{
    public partial class PaymentManagementForm : Form
    {
        public PaymentManagementForm()
        {
            InitializeComponent();
            LoadingSearchGridView();
            LoadingPackage();
            LoadingRegisterGridView();
        }

        private void LoadingPackage()
        {
            this.dtgv_package.DataSource = ParkingPackageBLL.Instance().getAllPackage();
            this.dtgv_package.Columns[0].Visible = false;
        }

        private void LoadingRegisterGridView()
        {

            this.dtgv_payment.DataSource = PaymentBLL.Instance.CreateRegisterDTable();
            this.dtgv_payment.Columns[RegisterDTableField.ID_CUSTOMER].Visible = false;
            this.dtgv_payment.Columns[RegisterDTableField.ID_PACKAGE].Visible = false;
        }

        private void LoadingSearchGridView()
        {
            this.dtgv_search.DataSource = this.CreateDTableSearch();
            this.dtgv_search.Columns[SearchDTableField.CUSTOMER_ID].Visible = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool isSelectedStudentId = this.rb_student_id.Checked;
            string textSearch = this.txt_search.Text.Trim();
            List<Customer> list;

            if (isSelectedStudentId)
            {
                list = CustomerBLL.Instance.GetCustomers(null, null, null, textSearch, null);
            }
            else
            {
                list = CustomerBLL.Instance.GetCustomers(textSearch, null, null, null, null);
            }

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(SearchDTableField.CUSTOMER_ID, typeof(int)),
                new DataColumn(SearchDTableField.STUDENT_ID, typeof(string)),
                new DataColumn(SearchDTableField.NAME, typeof(string))
            });

            foreach (Customer customer in list)
            {
                // skip all customer has card_id = null
                if (customer.card_id == null)
                    continue;

                DataRow dr = dt.NewRow();
                dr[SearchDTableField.CUSTOMER_ID] = customer.ID_customer;
                dr[SearchDTableField.STUDENT_ID] = customer.student_id;
                dr[SearchDTableField.NAME] = customer.fullname;

                dt.Rows.Add(dr);
            }

            this.dtgv_search.DataSource = dt;
            this.dtgv_search.Columns[SearchDTableField.CUSTOMER_ID].Visible = false;
        }

        private void dtgv_search_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dtgv_search.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = this.dtgv_search.SelectedRows[0];
                int customerId = Convert.ToInt32(dgvRow.Cells[SearchDTableField.CUSTOMER_ID].Value.ToString());

                DataTable dtPurchase = PaymentBLL.Instance.getAvailableAndUnpaidPackage(customerId);

                if (dtPurchase.Rows.Count > 0)
                {
                    //Console.WriteLine("HAs sda");
                    //this.dtgv_payment.DataSource = dt;
                    MessageBox.Show("Người dùng này có " + dtPurchase.Rows.Count + " gói chưa thanh toán!");
                    PurchaseRegisteredPaymentForm purchaseForm = new PurchaseRegisteredPaymentForm(dtPurchase);

                    purchaseForm.Show();
                }

                // handle
                Customer selectedCustomer = CustomerBLL.Instance.GetCustomerByID(customerId);

                if (selectedCustomer != null)
                {
                    if (this.dtgv_payment.Rows.Count == 0)
                    {
                        DataTable oldDt = (DataTable)this.dtgv_payment.DataSource;
                        DataRow newRow = oldDt.NewRow();
                        oldDt.Rows.Add(newRow);
                        this.dtgv_payment.DataSource = oldDt;
                    }

                    DataGridViewRow row = this.dtgv_payment.Rows[0];
                    row.Cells[RegisterDTableField.ID_CUSTOMER].Value = selectedCustomer.ID_customer;
                    row.Cells[RegisterDTableField.NAME].Value = selectedCustomer.fullname;
                    row.Cells[RegisterDTableField.STUDENT_ID].Value = selectedCustomer.student_id;
                }
            }
        }

        private void dtgv_package_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dtgv_package.SelectedRows.Count > 0)
            {
                DataGridViewRow dgvRow = this.dtgv_package.SelectedRows[0];
                int packageId = Convert.ToInt32(dgvRow.Cells[HeThongGiuXe.BLL.PackageDTableField.ID].Value.ToString());

                Parking_Package package = ParkingPackageBLL.Instance().FindById(packageId);

                if (package != null)
                {
                    if (this.dtgv_payment.Rows.Count == 0)
                    {
                        DataTable oldDt = (DataTable)this.dtgv_payment.DataSource;
                        DataRow newRow = oldDt.NewRow();
                        oldDt.Rows.Add(newRow);
                        this.dtgv_payment.DataSource = oldDt;
                    }

                    DataGridViewRow row = this.dtgv_payment.Rows[0];
                    row.Cells[RegisterDTableField.ID_PACKAGE].Value = package.ID_package;
                    row.Cells[RegisterDTableField.PACKAGE].Value = package.name;
                    row.Cells[RegisterDTableField.PRICE].Value = package.price;
                }
            }
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (this.dtgv_payment.Rows.Count > 0)
            {
                const string customerIdErrorMessage = "Vui lòng chọn khách hàng cần thanh toán!";
                const string packageIdErrorMessage = "Vui lòng chọn gói cần thanh toán!";

                DataGridViewCell customerIdCell = this.dtgv_payment.Rows[0].Cells[RegisterDTableField.ID_CUSTOMER];
                DataGridViewCell packageIdCell = this.dtgv_payment.Rows[0].Cells[RegisterDTableField.ID_PACKAGE];

                if (customerIdCell == null || customerIdCell.Value == DBNull.Value)
                {
                    MessageBox.Show(customerIdErrorMessage); 
                    return;
                }

                if (packageIdCell == null || packageIdCell.Value == DBNull.Value)
                {
                    MessageBox.Show(packageIdErrorMessage); 
                    return;
                }

                int cusomterId = Convert.ToInt32(customerIdCell.Value);
                if (cusomterId <= 0) { MessageBox.Show(customerIdErrorMessage); return; }

                int packageId = Convert.ToInt32(packageIdCell.Value);
                if (packageId <= 0) { MessageBox.Show(packageIdErrorMessage); return; }

                //=> cusomterId > 0 && packageId > 0
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắc đăng kí", "Thông báo", MessageBoxButtons.YesNo);

                // Không cho phép ngươi dung đăng kí gói mới khi:
                // + Hiện tại đang có gói chưa hết hạn
                // + Hiện tại đang có gói đã đăng kí nhưng thanh toán
                List<Payment> registeredPayments = PaymentBLL.Instance.GetCurrentRegisteredPackage(cusomterId);
                int unpaid = 0;
                int notExpire = 0;
                foreach (Payment payment in registeredPayments)
                {
                    if (payment.paid_at == null)
                    {
                        unpaid++;
                    } else
                    {
                        notExpire++;
                    }
                }

                if (unpaid != 0)
                {
                    MessageBox.Show("Bạn có " + unpaid.ToString() + " chưa thanh toán. Vui lòng thanh toán trước khi đăng kí gói mới, hoặc hủy đăng kí gói đó tại website");
                    return;
                }

                if (notExpire != 0)
                {
                    MessageBox.Show("Bạn có " + notExpire.ToString() + " còn hạn dùng đến thời điểm hiện tại. Bạn có thể đăng kí gói mới sau khi hết hạn gói hiện tại hoặc hủy gói hiện tại để đăng kí gói mới");
                    return;
                }

                if (dialogResult == DialogResult.Yes)
                {
                    PaymentBLL.Instance.RegisterPackage(packageId, cusomterId);
                    MessageBox.Show("Đăng kí thành công");

                    // reset gridview
                    LoadingRegisterGridView();
                }
            }
        }

        private DataTable CreateDTableSearch()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(SearchDTableField.CUSTOMER_ID, typeof(int)),
                new DataColumn(SearchDTableField.STUDENT_ID, typeof(string)),
                new DataColumn(SearchDTableField.NAME, typeof(string))
            });
            return dt;
        }

    }

    class SearchDTableField
    {
        public static string CUSTOMER_ID = "ID";
        public static string STUDENT_ID = "Mã sinh viên";
        public static string NAME = "Tên";
    }

    
    
}
