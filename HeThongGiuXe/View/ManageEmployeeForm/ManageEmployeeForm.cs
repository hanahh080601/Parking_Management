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
    public partial class ManageEmployeeForm : Form
    {
        private int? currentSelectedID = null;
        public ManageEmployeeForm()
        {
            InitializeComponent();
            SetCBBRole();
        }

        private void SetCBBRole()
        {
            DatabaseEntities db = new DatabaseEntities();
            foreach (Role i in db.Roles)
            {
                cbbRole.Items.Add(new Role
                {
                    ID_role = i.ID_role,
                    code = i.code,
                    description = i.description
                });
            }
            cbbRole.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearDetail();
            this.btnOK.Text = "Thêm";
            this.currentSelectedID = null;
        }
        private void clearDetail()
        {
            this.txtIDCardNumb.Clear();
            this.txtFullname.Clear();
            this.txtPassword.Clear();
            this.txtUsername.Clear();
            this.dateTimePicker1.Value = DateTime.Now;
            this.cbbRole.SelectedIndex = 0;
            this.rdbMale.Checked = true;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = this.btnShowAll.Enabled = false;
            try
            {
                this.tableEmployees.DataSource = EmployeeBLL.Instance.GetDataTableEmployees();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            this.tableEmployees.Columns[0].Visible = false;
            this.btnSearch.Enabled = this.btnShowAll.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = this.btnShowAll.Enabled = false;
            search();
            this.btnSearch.Enabled = this.btnShowAll.Enabled = true;
        }

        private void search()
        {
            string fullname = this.txtFullnameFilter.Text == "" ? null : this.txtFullnameFilter.Text;
            string IDcardnumb = this.txtStudentIDFilter.Text == "" ? null : this.txtStudentIDFilter.Text;
            try
            {
                this.tableEmployees.DataSource = EmployeeBLL.Instance.GetDataTableEmployees(
                fullname: fullname,
                IDcardnumb: IDcardnumb
                );
            }
            catch (Exception err)
            {

            }
            this.tableEmployees.Columns[0].Visible = false;
        }

        private void tableEmployees_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.tableEmployees.SelectedRows.Count == 0) return;
            int ID = Convert.ToInt32(this.tableEmployees.SelectedRows[0].Cells[0].Value);
            Employee employee = EmployeeBLL.Instance.GetEmployeeByID(ID);
            if (employee == null)
            {
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi dữ liệu");
                return;
            }
            LoadDetail(employee);
        }

        private void LoadDetail(Employee employee)
        {
            this.btnOK.Text = "Cập nhật";
            this.currentSelectedID = employee.ID_employee;
            this.txtIDCardNumb.Text = employee.identity_card_number;
            this.txtFullname.Text = employee.fullname;
            this.dateTimePicker1.Value = Convert.ToDateTime(employee.birthday);
            if (employee.gender == true) this.rdbMale.Checked = true;
            else this.rdbFemale.Checked = true;
            this.txtUsername.Text = employee.username;
            for(int i = 0; i < cbbRole.Items.Count; i++)
            {
                if (((Role)cbbRole.Items[i]).ID_role == employee.role_id) this.cbbRole.SelectedIndex = i;
            }    
        }

        private Employee GetDetail()
        {
            return new Employee
            {
                username = this.txtUsername.Text.Trim().Length == 0 ? null : this.txtUsername.Text.Trim(),
                identity_card_number = this.txtIDCardNumb.Text.Trim().Length == 0 ? null : this.txtIDCardNumb.Text.Trim(),
                role_id = ((Role)this.cbbRole.SelectedItem).ID_role,
                birthday = this.dateTimePicker1.Value,
                fullname = this.txtFullname.Text.Trim(),
                password = this.txtPassword.Text.Trim().Length == 0 ? null : this.txtPassword.Text.Trim(),
                gender = this.rdbMale.Checked == true ? true : false,
            };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Employee employee = GetDetail();
            if (this.currentSelectedID == null)
            {
                // Add
                try
                {
                    EmployeeBLL.Instance.CreateEmployee(employee);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi thông tin");
                    return;
                }
                clearDetail();
            }
            else
            {
                // Update
                employee.ID_employee = (int)this.currentSelectedID;
                try
                {
                    EmployeeBLL.Instance.UpdateEmployee(employee);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Lỗi thông tin");
                    return;
                }
                clearDetail();
                search();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedID == null) return;
            try
            {
                EmployeeBLL.Instance.DeleteEmployee((int)this.currentSelectedID);
                clearDetail();
                search();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Lỗi dữ liệu");
            }
        }

       
    }
}
