
namespace HeThongGiuXe.View
{
    partial class PaymentManagementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentManagementForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtgv_package = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_search = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_purchase = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.dtgv_payment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_student_id = new System.Windows.Forms.RadioButton();
            this.rb_name = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_search)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_payment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1128, 677);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(475, 633);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Click đúp chuột để chọn gói đăng kí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "* Click đúp chuột để chọn sinh viên đăng kí";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtgv_package);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox5.Location = new System.Drawing.Point(459, 312);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(641, 316);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Các gói gửi xe";
            // 
            // dtgv_package
            // 
            this.dtgv_package.AllowUserToAddRows = false;
            this.dtgv_package.AllowUserToDeleteRows = false;
            this.dtgv_package.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_package.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_package.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_package.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_package.Location = new System.Drawing.Point(20, 49);
            this.dtgv_package.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_package.MultiSelect = false;
            this.dtgv_package.Name = "dtgv_package";
            this.dtgv_package.ReadOnly = true;
            this.dtgv_package.RowHeadersVisible = false;
            this.dtgv_package.RowHeadersWidth = 51;
            this.dtgv_package.RowTemplate.Height = 24;
            this.dtgv_package.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_package.Size = new System.Drawing.Size(599, 258);
            this.dtgv_package.TabIndex = 1;
            this.dtgv_package.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_package_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_search);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox4.Location = new System.Drawing.Point(8, 312);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(433, 316);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kết quả tìm kiếm";
            // 
            // dtgv_search
            // 
            this.dtgv_search.AllowUserToAddRows = false;
            this.dtgv_search.AllowUserToDeleteRows = false;
            this.dtgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_search.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_search.Location = new System.Drawing.Point(8, 49);
            this.dtgv_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_search.MultiSelect = false;
            this.dtgv_search.Name = "dtgv_search";
            this.dtgv_search.ReadOnly = true;
            this.dtgv_search.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv_search.RowHeadersVisible = false;
            this.dtgv_search.RowHeadersWidth = 51;
            this.dtgv_search.RowTemplate.Height = 24;
            this.dtgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_search.Size = new System.Drawing.Size(402, 258);
            this.dtgv_search.TabIndex = 0;
            this.dtgv_search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_search_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_purchase);
            this.groupBox3.Controls.Add(this.dtgv_payment);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox3.Location = new System.Drawing.Point(373, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(727, 269);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đăng kí gói thanh toán";
            // 
            // btn_purchase
            // 
            this.btn_purchase.BackColor = System.Drawing.Color.Transparent;
            this.btn_purchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_purchase.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_purchase.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_purchase.FlatAppearance.BorderSize = 0;
            this.btn_purchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_purchase.Location = new System.Drawing.Point(536, 115);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_purchase.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_purchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_purchase.Size = new System.Drawing.Size(159, 55);
            this.btn_purchase.TabIndex = 6;
            this.btn_purchase.Text = "Xác nhận";
            this.btn_purchase.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // dtgv_payment
            // 
            this.dtgv_payment.AllowUserToAddRows = false;
            this.dtgv_payment.AllowUserToDeleteRows = false;
            this.dtgv_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_payment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_payment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_payment.Location = new System.Drawing.Point(25, 37);
            this.dtgv_payment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_payment.Name = "dtgv_payment";
            this.dtgv_payment.RowHeadersVisible = false;
            this.dtgv_payment.RowHeadersWidth = 51;
            this.dtgv_payment.RowTemplate.Height = 24;
            this.dtgv_payment.Size = new System.Drawing.Size(502, 212);
            this.dtgv_payment.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(345, 269);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_search.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_search.Location = new System.Drawing.Point(29, 181);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_search.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(287, 56);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb_student_id);
            this.groupBox6.Controls.Add(this.rb_name);
            this.groupBox6.Location = new System.Drawing.Point(29, 84);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(287, 86);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // rb_student_id
            // 
            this.rb_student_id.AutoSize = true;
            this.rb_student_id.Checked = true;
            this.rb_student_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_student_id.Location = new System.Drawing.Point(23, 37);
            this.rb_student_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_student_id.Name = "rb_student_id";
            this.rb_student_id.Size = new System.Drawing.Size(85, 32);
            this.rb_student_id.TabIndex = 2;
            this.rb_student_id.TabStop = true;
            this.rb_student_id.Text = "MSSV";
            this.rb_student_id.UseVisualStyleBackColor = true;
            // 
            // rb_name
            // 
            this.rb_name.AutoSize = true;
            this.rb_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_name.Location = new System.Drawing.Point(160, 37);
            this.rb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_name.Name = "rb_name";
            this.rb_name.Size = new System.Drawing.Size(121, 32);
            this.rb_name.TabIndex = 3;
            this.rb_name.Text = "Họ và tên";
            this.rb_name.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.rb_name.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_search.Location = new System.Drawing.Point(29, 52);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(287, 27);
            this.txt_search.TabIndex = 0;
            // 
            // PaymentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1168, 703);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaymentManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_search)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_payment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_name;
        private System.Windows.Forms.RadioButton rb_student_id;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtgv_search;
        private System.Windows.Forms.DataGridView dtgv_payment;
        private System.Windows.Forms.DataGridView dtgv_package;
        private System.Windows.Forms.GroupBox groupBox6;
        private DTO.RoundedButton btn_purchase;
        private DTO.RoundedButton btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}