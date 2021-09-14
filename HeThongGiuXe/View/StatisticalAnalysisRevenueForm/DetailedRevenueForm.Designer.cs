
namespace HeThongGiuXe.View
{
    partial class DetailedRevenueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedRevenueForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpk_1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgv_parking_payment = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_package_payment = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgv_revenue = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_parking_payment)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package_payment)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_revenue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpk_1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hành động";
            // 
            // dtpk_1
            // 
            this.dtpk_1.CustomFormat = "MM/yyyy";
            this.dtpk_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_1.Location = new System.Drawing.Point(39, 42);
            this.dtpk_1.Name = "dtpk_1";
            this.dtpk_1.Size = new System.Drawing.Size(216, 34);
            this.dtpk_1.TabIndex = 0;
            this.dtpk_1.ValueChanged += new System.EventHandler(this.dtpk_1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1330, 672);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgv_parking_payment);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox5.Location = new System.Drawing.Point(602, 353);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(722, 313);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết doanh thu tại quầy gửi xe";
            // 
            // dtgv_parking_payment
            // 
            this.dtgv_parking_payment.AllowUserToAddRows = false;
            this.dtgv_parking_payment.AllowUserToDeleteRows = false;
            this.dtgv_parking_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_parking_payment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_parking_payment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_parking_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_parking_payment.Location = new System.Drawing.Point(6, 33);
            this.dtgv_parking_payment.Name = "dtgv_parking_payment";
            this.dtgv_parking_payment.ReadOnly = true;
            this.dtgv_parking_payment.RowHeadersVisible = false;
            this.dtgv_parking_payment.RowHeadersWidth = 51;
            this.dtgv_parking_payment.RowTemplate.Height = 24;
            this.dtgv_parking_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_parking_payment.Size = new System.Drawing.Size(710, 274);
            this.dtgv_parking_payment.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_package_payment);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox4.Location = new System.Drawing.Point(602, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(722, 326);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết doanh thu các gói trả trước";
            // 
            // dtgv_package_payment
            // 
            this.dtgv_package_payment.AllowUserToAddRows = false;
            this.dtgv_package_payment.AllowUserToDeleteRows = false;
            this.dtgv_package_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_package_payment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_package_payment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_package_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_package_payment.Location = new System.Drawing.Point(6, 33);
            this.dtgv_package_payment.Name = "dtgv_package_payment";
            this.dtgv_package_payment.ReadOnly = true;
            this.dtgv_package_payment.RowHeadersVisible = false;
            this.dtgv_package_payment.RowHeadersWidth = 51;
            this.dtgv_package_payment.RowTemplate.Height = 24;
            this.dtgv_package_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_package_payment.Size = new System.Drawing.Size(710, 287);
            this.dtgv_package_payment.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgv_revenue);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 645);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh thu theo ngày trong tháng";
            // 
            // dtgv_revenue
            // 
            this.dtgv_revenue.AllowUserToAddRows = false;
            this.dtgv_revenue.AllowUserToDeleteRows = false;
            this.dtgv_revenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_revenue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_revenue.Location = new System.Drawing.Point(6, 33);
            this.dtgv_revenue.Name = "dtgv_revenue";
            this.dtgv_revenue.ReadOnly = true;
            this.dtgv_revenue.RowHeadersVisible = false;
            this.dtgv_revenue.RowHeadersWidth = 51;
            this.dtgv_revenue.RowTemplate.Height = 24;
            this.dtgv_revenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_revenue.Size = new System.Drawing.Size(564, 606);
            this.dtgv_revenue.TabIndex = 0;
            this.dtgv_revenue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_revenue_MouseDoubleClick);
            // 
            // DetailedRevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1354, 799);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailedRevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu chi tiết theo ngày";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_parking_payment)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package_payment)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_revenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpk_1;
        private System.Windows.Forms.DataGridView dtgv_revenue;
        private System.Windows.Forms.DataGridView dtgv_parking_payment;
        private System.Windows.Forms.DataGridView dtgv_package_payment;
    }
}