
namespace HeThongGiuXe.View
{
    partial class ParkingPackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingPackageForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_update = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_add = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_search = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.check_visible = new System.Windows.Forms.CheckBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_package = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1088, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox3.Location = new System.Drawing.Point(588, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(488, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_delete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_delete.Location = new System.Drawing.Point(327, 62);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_delete.Size = new System.Drawing.Size(144, 52);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_update.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_update.Location = new System.Drawing.Point(173, 62);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_update.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_update.Size = new System.Drawing.Size(144, 52);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_add.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_add.Location = new System.Drawing.Point(19, 62);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_add.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_add.Size = new System.Drawing.Size(144, 52);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm";
            this.btn_add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.check_visible);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Location = new System.Drawing.Point(8, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(572, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_clear.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_clear.Location = new System.Drawing.Point(414, 95);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_clear.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_clear.Size = new System.Drawing.Size(144, 42);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Xóa";
            this.btn_clear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_clear.UseVisualStyleBackColor = false;
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
            this.btn_search.Location = new System.Drawing.Point(414, 36);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_search.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search.Size = new System.Drawing.Size(144, 42);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // check_visible
            // 
            this.check_visible.AutoSize = true;
            this.check_visible.Checked = true;
            this.check_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_visible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_visible.Location = new System.Drawing.Point(162, 95);
            this.check_visible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.check_visible.Name = "check_visible";
            this.check_visible.Size = new System.Drawing.Size(90, 32);
            this.check_visible.TabIndex = 3;
            this.check_visible.Text = "Visible";
            this.check_visible.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(44, 46);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(339, 27);
            this.txt_search.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_package);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox4.Location = new System.Drawing.Point(13, 191);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(1088, 477);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dtgv_package
            // 
            this.dtgv_package.AllowUserToAddRows = false;
            this.dtgv_package.AllowUserToDeleteRows = false;
            this.dtgv_package.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_package.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_package.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_package.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_package.Location = new System.Drawing.Point(8, 37);
            this.dtgv_package.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_package.Name = "dtgv_package";
            this.dtgv_package.ReadOnly = true;
            this.dtgv_package.RowHeadersVisible = false;
            this.dtgv_package.RowHeadersWidth = 51;
            this.dtgv_package.RowTemplate.Height = 24;
            this.dtgv_package.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_package.Size = new System.Drawing.Size(1068, 428);
            this.dtgv_package.TabIndex = 0;
            // 
            // ParkingPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1114, 682);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ParkingPackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí gói đỗ xe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_package)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_visible;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgv_package;
        private DTO.RoundedButton btn_delete;
        private DTO.RoundedButton btn_update;
        private DTO.RoundedButton btn_add;
        private DTO.RoundedButton btn_clear;
        private DTO.RoundedButton btn_search;
    }
}