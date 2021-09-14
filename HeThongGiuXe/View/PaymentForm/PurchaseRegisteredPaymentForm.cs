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

namespace HeThongGiuXe.View
{
    public partial class PurchaseRegisteredPaymentForm : Form
    {
        public PurchaseRegisteredPaymentForm(DataTable dt)
        {
            InitializeComponent();
            RenderDataGridView(dt);
        }

        public void RenderDataGridView(DataTable dt)
        {
            this.dtgv_purchase.DataSource = dt;
            this.dtgv_purchase.Columns[PurchaseDTableField.ID_CUSTOMER].Visible = false;
            this.dtgv_purchase.Columns[PurchaseDTableField.ID_PAYMENT].Visible = false;
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            if (this.dtgv_purchase.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dtgv_purchase.SelectedRows[0];
                int customerId = Convert.ToInt32(row.Cells[PurchaseDTableField.ID_CUSTOMER].Value.ToString());
                int paymentId = Convert.ToInt32(row.Cells[PurchaseDTableField.ID_PAYMENT].Value.ToString());

                if (customerId <= 0 || paymentId <= 0)
                {
                    MessageBox.Show("Khách hàng hoặc gói thanh toán không hợp lệ. Vui lòng tải lại trang!");
                } else
                {
                    bool result = PaymentBLL.Instance.PurchaseRegisteredPayment(customerId, paymentId);
                    if (result == true)
                    {
                        MessageBox.Show("Thanh toán thành công");
                        this.dtgv_purchase.Rows.RemoveAt(row.Index);
                    } else
                    {
                        MessageBox.Show("Thanh toán thất bại");
                    }

                }
            } else
            {
                MessageBox.Show("Vui lòng chọn thanh toán cần thực hiện!");
            }
        }
    }
}
