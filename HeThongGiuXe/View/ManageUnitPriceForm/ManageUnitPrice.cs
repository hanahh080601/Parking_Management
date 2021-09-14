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
    public partial class ManageUnitPrice : Form
    {
        private int? SelectdID = null;
        public ManageUnitPrice()
        {
            InitializeComponent();
            InitializeDatePicker();
        }
        private void InitializeDatePicker()
        {
            this.dateFilter.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateStart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int day = this.cbDay.SelectedIndex + 1; // day start from 1 as Sunday
            this.tableDayPrice.DataSource = null;
            this.cbDay.Enabled = false;
            this.btnSaveChange.Enabled = false;
            try
            {
                this.tableDayPrice.DataSource = UnitPriceBLL.Instance.GetDataTablePriceByDay(day);
            } catch(Exception err)
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu", "Lỗi hệ thống");
            }
            this.cbDay.Enabled = true;
            this.btnSaveChange.Enabled = true;
        }
        private List<Unit_Price> GetDayUnitPriceFromTable()
        {
            List<Unit_Price> results = new List<Unit_Price>();
            int day = this.cbDay.SelectedIndex + 1;
            for (int i = 0;i < this.tableDayPrice.Rows.Count - 1;i++)
            {
                DataGridViewRow row = this.tableDayPrice.Rows[i];
                try
                {
                    TimeSpan start = TimeSpan.Parse(row.Cells["Bắt đầu"].Value.ToString());
                    TimeSpan end = TimeSpan.Parse(row.Cells["Kết thúc"].Value.ToString());
                    int price = Convert.ToInt32(row.Cells["Giá"].Value);
                    var exist = results.Find(o => (o.start_time_in_day <= start && o.end_time_in_day >= start)
                                   || (o.start_time_in_day <= end && o.end_time_in_day >= end)
                        );
                    if (exist != default(Unit_Price))
                    {
                        throw new Exception("Thời gian bị chồng chéo lên nhau, vui lòng kiểm tra lại");
                    }
                    if (price < 0 || price % 1000 != 0)
                    {
                        throw new Exception("Gía tiền không hợp lệ");
                    }
                    results.Add(new Unit_Price
                    {
                        day_in_week = day,
                        start_time_in_day = start,
                        end_time_in_day = end,
                        price = price,
                    }) ;
                } catch (Exception err) {
                    row.Selected = true;
                    results = null;
                    MessageBox.Show(err.Message, "Lỗi dữ liệu");
                    return null;
                }
            }
            return results;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            List<Unit_Price> data = GetDayUnitPriceFromTable();
            if (data == null) return;
            var confirmReult = MessageBox.Show("Tất cả đơn giá trong ngày này sẽ được cập nhập. Bạn có chắc chắn muốn cập nhật?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirmReult == DialogResult.No) return;
            int day = this.cbDay.SelectedIndex + 1;
            this.btnSaveChange.Enabled = false;
            this.cbDay.Enabled = false;
            this.tableDayPrice.Enabled = false;
            try
            {
                UnitPriceBLL.Instance.UpdateUnitPriceInDay(day, data);
            } catch(Exception err)
            {
                MessageBox.Show("Không thể truy cập cơ sở dữ liệu", "Lỗi hệ thống");
                Console.WriteLine(err.Message);
            }
            this.btnSaveChange.Enabled = true;
            this.cbDay.Enabled = true;
            this.tableDayPrice.Enabled = true;
        }
        private Unit_Price GetSpecialPrice()
        {
            try
            {
                if (this.dateStart.Value >= this.dateEnd.Value)
                {
                    throw new Exception();
                }
                int price = Convert.ToInt32(this.txtPrice.Text);
                if (price < 0 || price % 1000 != 0) throw new Exception();
                return new Unit_Price
                {
                    description = this.txtDescription.Text,
                    start_date = this.dateStart.Value,
                    end_date = this.dateEnd.Value,
                    price = price,
                };
            } catch (Exception err)
            {
                MessageBox.Show("Dữ liệu không hợp lễ", "Lỗi dữ liệu");
            }
            return null;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Unit_Price unitPrice = GetSpecialPrice();
            if (unitPrice == null) return;
            if (this.SelectdID == null)
            {
                try
                {
                    UnitPriceBLL.Instance.CreateUnitPrice(unitPrice);
                    ClearDetail();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Lỗi truy cập cơ sở dữ liệu", "Lỗi hệ thống");
                    Console.WriteLine(err.Message);
                    return;
                }
            } else
            {
                try
                {
                    UnitPriceBLL.Instance.UpdateUnitPriceByID((int)this.SelectdID, unitPrice);
                    ClearDetail();
                    ShowAll();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Lỗi truy cập cơ sở dữ liệu", "Lỗi hệ thống");
                    Console.WriteLine(err.Message);
                    return;
                }
            }
            

        }
        private void ClearDetail()
        {
            this.SelectdID = null;
            this.btnOK.Text = "Thêm";
            this.txtDescription.Clear();
            this.txtPrice.Clear();
            this.dateStart.Value = DateTime.Now;
            this.dateEnd.Value = DateTime.Now;
            this.btnDelete.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearDetail();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.btnSearch.Enabled = false;
            this.tableSpecialPrice.DataSource = null;
            Search();
            this.btnSearch.Enabled = true;
        }
        private void Search()
        {
            try
            {
                this.tableSpecialPrice.DataSource =
                UnitPriceBLL.Instance.GetDataTableByDate(this.dateFilter.Value);
                this.tableSpecialPrice.Columns[0].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể truy cập cơ sở dữ liệu", "Lỗi hệ thống");
                Console.WriteLine(err.Message);
            }
        }
        private void ShowAll()
        {
            try
            {
                this.tableSpecialPrice.DataSource =
                UnitPriceBLL.Instance.GetDataTableByDate();
                this.tableSpecialPrice.Columns[0].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Không thể truy cập cơ sở dữ liệu", "Lỗi hệ thống");
                Console.WriteLine(err.Message);
            }
        }
        private void SetDetail(Unit_Price unitPrice)
        {
            this.SelectdID = unitPrice.ID_unit_price;
            this.dateStart.Value = (DateTime)unitPrice.start_date;
            this.dateEnd.Value = (DateTime)unitPrice.end_date;
            this.txtPrice.Text = unitPrice.price.ToString();
            this.txtDescription.Text = unitPrice.description.ToString();
        }
        private void tableSpecialPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(tableSpecialPrice.SelectedRows[0].Cells[0].Value.ToString());
            try
            {
                SetDetail(UnitPriceBLL.Instance.GetUnitPriceByID(ID));
                this.SelectdID = ID;
                this.btnOK.Text = "Cập nhật";
                this.btnDelete.Enabled = true;
            }
            catch (Exception err)
            {
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UnitPriceBLL.Instance.DeleteUnitPriceByID((int)this.SelectdID);
                ShowAll();
            } catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

     
    }
}
