
namespace HeThongGiuXe.View
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.lbLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLoading
            // 
            this.imgLoading.BackColor = System.Drawing.Color.Transparent;
            this.imgLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLoading.InitialImage = null;
            this.imgLoading.Location = new System.Drawing.Point(176, 14);
            this.imgLoading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(107, 106);
            this.imgLoading.TabIndex = 0;
            this.imgLoading.TabStop = false;
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Location = new System.Drawing.Point(116, 134);
            this.lbLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(217, 28);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.Text = "Đang tải, Vui lòng chờ...";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(473, 203);
            this.ControlBox = false;
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.imgLoading);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.Label lbLoading;
    }
}