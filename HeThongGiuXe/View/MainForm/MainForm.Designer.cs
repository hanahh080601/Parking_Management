
namespace HeThongGiuXe.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imgDUT = new System.Windows.Forms.PictureBox();
            this.imgSgroup = new System.Windows.Forms.PictureBox();
            this.imgIT = new System.Windows.Forms.PictureBox();
            this.lbHeader1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.lbLogout = new System.Windows.Forms.Label();
            this.btnCheckin = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnCheckout = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnParkingManagement = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnGeneralManagement = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnManageManager = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_paring_package = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_analysis = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnUnitPrice = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btn_payment = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSgroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDUT
            // 
            this.imgDUT.BackgroundImage = global::HeThongGiuXe.Properties.Resources.Logo_DUT;
            this.imgDUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgDUT.Location = new System.Drawing.Point(373, 23);
            this.imgDUT.Name = "imgDUT";
            this.imgDUT.Size = new System.Drawing.Size(79, 79);
            this.imgDUT.TabIndex = 4;
            this.imgDUT.TabStop = false;
            // 
            // imgSgroup
            // 
            this.imgSgroup.BackgroundImage = global::HeThongGiuXe.Properties.Resources.Logo_Sgroup;
            this.imgSgroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgSgroup.Location = new System.Drawing.Point(584, 23);
            this.imgSgroup.Name = "imgSgroup";
            this.imgSgroup.Size = new System.Drawing.Size(82, 79);
            this.imgSgroup.TabIndex = 5;
            this.imgSgroup.TabStop = false;
            // 
            // imgIT
            // 
            this.imgIT.BackgroundImage = global::HeThongGiuXe.Properties.Resources.Logo_IT;
            this.imgIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgIT.Location = new System.Drawing.Point(481, 23);
            this.imgIT.Name = "imgIT";
            this.imgIT.Size = new System.Drawing.Size(77, 79);
            this.imgIT.TabIndex = 6;
            this.imgIT.TabStop = false;
            // 
            // lbHeader1
            // 
            this.lbHeader1.AutoSize = true;
            this.lbHeader1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbHeader1.Location = new System.Drawing.Point(477, 118);
            this.lbHeader1.Name = "lbHeader1";
            this.lbHeader1.Size = new System.Drawing.Size(91, 29);
            this.lbHeader1.TabIndex = 7;
            this.lbHeader1.Text = "DỰ ÁN";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Orange;
            this.lbName.Location = new System.Drawing.Point(224, 164);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(585, 29);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "HỆ THỐNG QUẢN LÍ BÃI ĐỖ XE MÁY SINH VIÊN";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFullname.Location = new System.Drawing.Point(441, 489);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(0, 28);
            this.lbFullname.TabIndex = 11;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbLogout.Location = new System.Drawing.Point(440, 540);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(128, 32);
            this.lbLogout.TabIndex = 12;
            this.lbLogout.Text = "Đăng xuất";
            this.lbLogout.Click += new System.EventHandler(this.lbLogout_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCheckin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCheckin.FlatAppearance.BorderSize = 0;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnCheckin.Location = new System.Drawing.Point(121, 230);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCheckin.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnCheckin.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnCheckin.Size = new System.Drawing.Size(254, 60);
            this.btnCheckin.TabIndex = 16;
            this.btnCheckin.Text = "Quản lí xe vào";
            this.btnCheckin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCheckout.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnCheckout.Location = new System.Drawing.Point(400, 230);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCheckout.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnCheckout.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnCheckout.Size = new System.Drawing.Size(254, 60);
            this.btnCheckout.TabIndex = 17;
            this.btnCheckout.Text = "Quản lí xe ra";
            this.btnCheckout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnParkingManagement
            // 
            this.btnParkingManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnParkingManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParkingManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnParkingManagement.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnParkingManagement.FlatAppearance.BorderSize = 0;
            this.btnParkingManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnParkingManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnParkingManagement.Location = new System.Drawing.Point(678, 230);
            this.btnParkingManagement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnParkingManagement.Name = "btnParkingManagement";
            this.btnParkingManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnParkingManagement.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnParkingManagement.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnParkingManagement.Size = new System.Drawing.Size(254, 60);
            this.btnParkingManagement.TabIndex = 18;
            this.btnParkingManagement.Text = "Quản lí xe trong bãi";
            this.btnParkingManagement.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnParkingManagement.UseVisualStyleBackColor = false;
            this.btnParkingManagement.Click += new System.EventHandler(this.btnParkingManagement_Click);
            // 
            // btnGeneralManagement
            // 
            this.btnGeneralManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnGeneralManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeneralManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnGeneralManagement.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnGeneralManagement.FlatAppearance.BorderSize = 0;
            this.btnGeneralManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneralManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGeneralManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnGeneralManagement.Location = new System.Drawing.Point(121, 311);
            this.btnGeneralManagement.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGeneralManagement.Name = "btnGeneralManagement";
            this.btnGeneralManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnGeneralManagement.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnGeneralManagement.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnGeneralManagement.Size = new System.Drawing.Size(254, 60);
            this.btnGeneralManagement.TabIndex = 19;
            this.btnGeneralManagement.Text = "Quản lí người dùng";
            this.btnGeneralManagement.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnGeneralManagement.UseVisualStyleBackColor = false;
            this.btnGeneralManagement.Click += new System.EventHandler(this.btnGeneralManagement_Click);
            // 
            // btnManageManager
            // 
            this.btnManageManager.BackColor = System.Drawing.Color.Transparent;
            this.btnManageManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnManageManager.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnManageManager.FlatAppearance.BorderSize = 0;
            this.btnManageManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManageManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnManageManager.Location = new System.Drawing.Point(400, 311);
            this.btnManageManager.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnManageManager.Name = "btnManageManager";
            this.btnManageManager.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnManageManager.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnManageManager.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnManageManager.Size = new System.Drawing.Size(254, 60);
            this.btnManageManager.TabIndex = 20;
            this.btnManageManager.Text = "Quản lí nhân viên";
            this.btnManageManager.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnManageManager.UseVisualStyleBackColor = false;
            this.btnManageManager.Click += new System.EventHandler(this.btnManageManager_Click);
            // 
            // btn_paring_package
            // 
            this.btn_paring_package.BackColor = System.Drawing.Color.Transparent;
            this.btn_paring_package.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_paring_package.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_paring_package.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_paring_package.FlatAppearance.BorderSize = 0;
            this.btn_paring_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_paring_package.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_paring_package.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_paring_package.Location = new System.Drawing.Point(121, 392);
            this.btn_paring_package.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_paring_package.Name = "btn_paring_package";
            this.btn_paring_package.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_paring_package.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_paring_package.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_paring_package.Size = new System.Drawing.Size(254, 60);
            this.btn_paring_package.TabIndex = 21;
            this.btn_paring_package.Text = "Quản lí các gói giữ xe";
            this.btn_paring_package.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_paring_package.UseVisualStyleBackColor = false;
            this.btn_paring_package.Click += new System.EventHandler(this.btn_paring_package_Click);
            // 
            // btn_analysis
            // 
            this.btn_analysis.BackColor = System.Drawing.Color.Transparent;
            this.btn_analysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_analysis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_analysis.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_analysis.FlatAppearance.BorderSize = 0;
            this.btn_analysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_analysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_analysis.Location = new System.Drawing.Point(678, 311);
            this.btn_analysis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_analysis.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_analysis.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_analysis.Size = new System.Drawing.Size(254, 60);
            this.btn_analysis.TabIndex = 22;
            this.btn_analysis.Text = "Quản lí - thống kê";
            this.btn_analysis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_analysis.UseVisualStyleBackColor = false;
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // btnUnitPrice
            // 
            this.btnUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnUnitPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnUnitPrice.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnUnitPrice.FlatAppearance.BorderSize = 0;
            this.btnUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btnUnitPrice.Location = new System.Drawing.Point(400, 392);
            this.btnUnitPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUnitPrice.Name = "btnUnitPrice";
            this.btnUnitPrice.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnUnitPrice.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnUnitPrice.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnUnitPrice.Size = new System.Drawing.Size(254, 60);
            this.btnUnitPrice.TabIndex = 23;
            this.btnUnitPrice.Text = "Quản lí đơn giá";
            this.btnUnitPrice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnUnitPrice.UseVisualStyleBackColor = false;
            this.btnUnitPrice.Click += new System.EventHandler(this.btnUnitPrice_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.Transparent;
            this.btn_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_payment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_payment.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_payment.Location = new System.Drawing.Point(678, 392);
            this.btn_payment.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_payment.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_payment.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_payment.Size = new System.Drawing.Size(254, 60);
            this.btn_payment.TabIndex = 24;
            this.btn_payment.Text = "Thanh toán";
            this.btn_payment.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeThongGiuXe.Properties.Resources.login__1_;
            this.pictureBox1.Location = new System.Drawing.Point(574, 540);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1051, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btnUnitPrice);
            this.Controls.Add(this.btn_analysis);
            this.Controls.Add(this.btn_paring_package);
            this.Controls.Add(this.btnManageManager);
            this.Controls.Add(this.btnGeneralManagement);
            this.Controls.Add(this.btnParkingManagement);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbHeader1);
            this.Controls.Add(this.imgIT);
            this.Controls.Add(this.imgSgroup);
            this.Controls.Add(this.imgDUT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn tác vụ";
            ((System.ComponentModel.ISupportInitialize)(this.imgDUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSgroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imgDUT;
        private System.Windows.Forms.PictureBox imgSgroup;
        private System.Windows.Forms.PictureBox imgIT;
        private System.Windows.Forms.Label lbHeader1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbLogout;
        private DTO.RoundedButton btnCheckin;
        private DTO.RoundedButton btnCheckout;
        private DTO.RoundedButton btnParkingManagement;
        private DTO.RoundedButton btnGeneralManagement;
        private DTO.RoundedButton btnManageManager;
        private DTO.RoundedButton btn_paring_package;
        private DTO.RoundedButton btn_analysis;
        private DTO.RoundedButton btnUnitPrice;
        private DTO.RoundedButton btn_payment;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

