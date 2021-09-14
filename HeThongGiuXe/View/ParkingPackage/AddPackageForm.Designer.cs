
namespace HeThongGiuXe.View
{
    partial class AddPackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPackageForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_duration = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.check_visible = new System.Windows.Forms.CheckBox();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.rtxt_description = new System.Windows.Forms.RichTextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_clear = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_add = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_duration);
            this.groupBox1.Controls.Add(this.lb_description);
            this.groupBox1.Controls.Add(this.lb_price);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.check_visible);
            this.groupBox1.Controls.Add(this.txt_duration);
            this.groupBox1.Controls.Add(this.rtxt_description);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lb_duration
            // 
            this.lb_duration.AutoSize = true;
            this.lb_duration.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_duration.Location = new System.Drawing.Point(346, 30);
            this.lb_duration.Name = "lb_duration";
            this.lb_duration.Size = new System.Drawing.Size(111, 28);
            this.lb_duration.TabIndex = 9;
            this.lb_duration.Text = "Thời lượng";
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(28, 115);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(65, 28);
            this.lb_description.TabIndex = 8;
            this.lb_description.Text = "Mô tả";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(28, 273);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(41, 28);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "Giá";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(28, 30);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(44, 28);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Tên";
            // 
            // check_visible
            // 
            this.check_visible.AutoSize = true;
            this.check_visible.Checked = true;
            this.check_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_visible.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_visible.Location = new System.Drawing.Point(351, 145);
            this.check_visible.Name = "check_visible";
            this.check_visible.Size = new System.Drawing.Size(94, 32);
            this.check_visible.TabIndex = 5;
            this.check_visible.Text = "Visible";
            this.check_visible.UseVisualStyleBackColor = true;
            // 
            // txt_duration
            // 
            this.txt_duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_duration.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_duration.Location = new System.Drawing.Point(351, 61);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(173, 27);
            this.txt_duration.TabIndex = 4;
            this.txt_duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_duration_KeyPress);
            // 
            // rtxt_description
            // 
            this.rtxt_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.rtxt_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_description.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtxt_description.Location = new System.Drawing.Point(33, 146);
            this.rtxt_description.Name = "rtxt_description";
            this.rtxt_description.Size = new System.Drawing.Size(242, 96);
            this.rtxt_description.TabIndex = 3;
            this.rtxt_description.Text = "";
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_price.Location = new System.Drawing.Point(33, 304);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(242, 27);
            this.txt_price.TabIndex = 2;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_name.Location = new System.Drawing.Point(33, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(242, 27);
            this.txt_name.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 147);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hành động";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_cancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_cancel.Location = new System.Drawing.Point(371, 53);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_cancel.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Size = new System.Drawing.Size(122, 51);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_clear.Location = new System.Drawing.Point(196, 53);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_clear.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_clear.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_clear.Size = new System.Drawing.Size(135, 51);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Xóa";
            this.btn_clear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_add.Location = new System.Drawing.Point(33, 53);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_add.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_add.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_add.Size = new System.Drawing.Size(120, 51);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm";
            this.btn_add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddPackageForm
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(579, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới gói gửi xe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_duration;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.CheckBox check_visible;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.RichTextBox rtxt_description;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private DTO.RoundedButton btn_cancel;
        private DTO.RoundedButton btn_clear;
        private DTO.RoundedButton btn_add;
    }
}