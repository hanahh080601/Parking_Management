
namespace HeThongGiuXe.View
{
    partial class SerialSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialSettingForm));
            this.lbPort = new System.Windows.Forms.Label();
            this.lbBaund = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.txtBaund = new System.Windows.Forms.TextBox();
            this.btnCancel = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnOK = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.SuspendLayout();
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.Location = new System.Drawing.Point(37, 42);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(146, 28);
            this.lbPort.TabIndex = 0;
            this.lbPort.Text = "Cổng giao tiếp";
            // 
            // lbBaund
            // 
            this.lbBaund.AutoSize = true;
            this.lbBaund.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaund.Location = new System.Drawing.Point(40, 94);
            this.lbBaund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBaund.Name = "lbBaund";
            this.lbBaund.Size = new System.Drawing.Size(139, 28);
            this.lbBaund.TabIndex = 1;
            this.lbBaund.Text = "Tốc độ truyền";
            // 
            // cbPorts
            // 
            this.cbPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorts.ForeColor = System.Drawing.SystemColors.Window;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(207, 39);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(165, 36);
            this.cbPorts.TabIndex = 2;
            // 
            // txtBaund
            // 
            this.txtBaund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtBaund.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBaund.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBaund.Location = new System.Drawing.Point(207, 95);
            this.txtBaund.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaund.Name = "txtBaund";
            this.txtBaund.Size = new System.Drawing.Size(165, 27);
            this.txtBaund.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnCancel.Location = new System.Drawing.Point(207, 161);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnCancel.Size = new System.Drawing.Size(141, 51);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnOK.Location = new System.Drawing.Point(63, 161);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnOK.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnOK.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnOK.Size = new System.Drawing.Size(116, 51);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SerialSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(454, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBaund);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.lbBaund);
            this.Controls.Add(this.lbPort);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SerialSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt giao tiếp serial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbBaund;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.TextBox txtBaund;
        private DTO.RoundedButton btnOK;
        private DTO.RoundedButton btnCancel;
    }
}