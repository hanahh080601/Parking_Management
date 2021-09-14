
namespace HeThongGiuXe.View
{
    partial class PurchaseRegisteredPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseRegisteredPaymentForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_purchase = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.dtgv_purchase = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_purchase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_purchase);
            this.groupBox1.Controls.Add(this.dtgv_purchase);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.btn_purchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_purchase.Location = new System.Drawing.Point(383, 321);
            this.btn_purchase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_purchase.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_purchase.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_purchase.Size = new System.Drawing.Size(212, 51);
            this.btn_purchase.TabIndex = 7;
            this.btn_purchase.Text = "Thanh toán ngay";
            this.btn_purchase.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_purchase.UseVisualStyleBackColor = false;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // dtgv_purchase
            // 
            this.dtgv_purchase.AllowUserToAddRows = false;
            this.dtgv_purchase.AllowUserToDeleteRows = false;
            this.dtgv_purchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_purchase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_purchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_purchase.Location = new System.Drawing.Point(8, 21);
            this.dtgv_purchase.Name = "dtgv_purchase";
            this.dtgv_purchase.ReadOnly = true;
            this.dtgv_purchase.RowHeadersVisible = false;
            this.dtgv_purchase.RowHeadersWidth = 51;
            this.dtgv_purchase.RowTemplate.Height = 24;
            this.dtgv_purchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_purchase.Size = new System.Drawing.Size(962, 281);
            this.dtgv_purchase.TabIndex = 0;
            // 
            // PurchaseRegisteredPaymentForm
            // 
            this.AcceptButton = this.btn_purchase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1001, 414);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseRegisteredPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách các gói chưa thanh toán";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_purchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_purchase;
        private DTO.RoundedButton btn_purchase;
    }
}