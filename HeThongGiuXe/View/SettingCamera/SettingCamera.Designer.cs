
namespace HeThongGiuXe.View
{
    partial class SettingCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingCamera));
            this.lbCameraSelect = new System.Windows.Forms.Label();
            this.txtCamera = new System.Windows.Forms.TextBox();
            this.btnOK = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnCacel = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.SuspendLayout();
            // 
            // lbCameraSelect
            // 
            this.lbCameraSelect.AutoSize = true;
            this.lbCameraSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCameraSelect.Location = new System.Drawing.Point(77, 42);
            this.lbCameraSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCameraSelect.Name = "lbCameraSelect";
            this.lbCameraSelect.Size = new System.Drawing.Size(81, 28);
            this.lbCameraSelect.TabIndex = 0;
            this.lbCameraSelect.Text = "Thiết bị";
            // 
            // txtCamera
            // 
            this.txtCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtCamera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCamera.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCamera.Location = new System.Drawing.Point(164, 43);
            this.txtCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(226, 27);
            this.txtCamera.TabIndex = 4;
            this.txtCamera.Text = "0";
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
            this.btnOK.Location = new System.Drawing.Point(82, 108);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnOK.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnOK.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnOK.Size = new System.Drawing.Size(132, 51);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCacel
            // 
            this.btnCacel.BackColor = System.Drawing.Color.Transparent;
            this.btnCacel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCacel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCacel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCacel.FlatAppearance.BorderSize = 0;
            this.btnCacel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCacel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCacel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnCacel.Location = new System.Drawing.Point(247, 108);
            this.btnCacel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCacel.Name = "btnCacel";
            this.btnCacel.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCacel.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnCacel.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnCacel.Size = new System.Drawing.Size(143, 51);
            this.btnCacel.TabIndex = 8;
            this.btnCacel.Text = "Hủy";
            this.btnCacel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCacel.UseVisualStyleBackColor = false;
            this.btnCacel.Click += new System.EventHandler(this.btnCacel_Click);
            // 
            // SettingCamera
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(463, 224);
            this.Controls.Add(this.btnCacel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCamera);
            this.Controls.Add(this.lbCameraSelect);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt camera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCameraSelect;
        private System.Windows.Forms.TextBox txtCamera;
        private DTO.RoundedButton btnOK;
        private DTO.RoundedButton btnCacel;
    }
}