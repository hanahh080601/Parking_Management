
namespace HeThongGiuXe.View
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.groupCamera = new System.Windows.Forms.GroupBox();
            this.imgCamera = new Emgu.CV.UI.ImageBox();
            this.groupExtractInfo = new System.Windows.Forms.GroupBox();
            this.groupPlateInfo = new System.Windows.Forms.GroupBox();
            this.btnSettingCamera = new System.Windows.Forms.Button();
            this.btnTryGetPlate = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.lbPlate = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.groupSaveInfo = new System.Windows.Forms.GroupBox();
            this.txtSavedPlate = new System.Windows.Forms.TextBox();
            this.btnSetingSerial = new System.Windows.Forms.Button();
            this.lbStatusCard = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.groupManageControll = new System.Windows.Forms.GroupBox();
            this.btlGetAllInPark = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnFilterWithPlate = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.tableVehicleInPark = new System.Windows.Forms.DataGridView();
            this.groupConfirmControl = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.checkAutoCheckout = new System.Windows.Forms.CheckBox();
            this.groupControlSOS = new System.Windows.Forms.GroupBox();
            this.btnClose = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnOpen = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).BeginInit();
            this.groupExtractInfo.SuspendLayout();
            this.groupPlateInfo.SuspendLayout();
            this.groupSaveInfo.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.groupManageControll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleInPark)).BeginInit();
            this.groupConfirmControl.SuspendLayout();
            this.groupControlSOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCamera
            // 
            this.groupCamera.Controls.Add(this.imgCamera);
            this.groupCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupCamera.Location = new System.Drawing.Point(27, 19);
            this.groupCamera.Margin = new System.Windows.Forms.Padding(4);
            this.groupCamera.Name = "groupCamera";
            this.groupCamera.Padding = new System.Windows.Forms.Padding(4);
            this.groupCamera.Size = new System.Drawing.Size(685, 395);
            this.groupCamera.TabIndex = 0;
            this.groupCamera.TabStop = false;
            this.groupCamera.Text = "Camera";
            // 
            // imgCamera
            // 
            this.imgCamera.Location = new System.Drawing.Point(24, 38);
            this.imgCamera.Margin = new System.Windows.Forms.Padding(4);
            this.imgCamera.Name = "imgCamera";
            this.imgCamera.Size = new System.Drawing.Size(644, 335);
            this.imgCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCamera.TabIndex = 2;
            this.imgCamera.TabStop = false;
            // 
            // groupExtractInfo
            // 
            this.groupExtractInfo.Controls.Add(this.groupPlateInfo);
            this.groupExtractInfo.Controls.Add(this.groupSaveInfo);
            this.groupExtractInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupExtractInfo.Location = new System.Drawing.Point(27, 439);
            this.groupExtractInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupExtractInfo.Name = "groupExtractInfo";
            this.groupExtractInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupExtractInfo.Size = new System.Drawing.Size(685, 266);
            this.groupExtractInfo.TabIndex = 1;
            this.groupExtractInfo.TabStop = false;
            this.groupExtractInfo.Text = "Trích xuất thông tin";
            // 
            // groupPlateInfo
            // 
            this.groupPlateInfo.CausesValidation = false;
            this.groupPlateInfo.Controls.Add(this.btnSettingCamera);
            this.groupPlateInfo.Controls.Add(this.btnTryGetPlate);
            this.groupPlateInfo.Controls.Add(this.lbPlate);
            this.groupPlateInfo.Controls.Add(this.txtPlate);
            this.groupPlateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupPlateInfo.Location = new System.Drawing.Point(356, 46);
            this.groupPlateInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupPlateInfo.Name = "groupPlateInfo";
            this.groupPlateInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupPlateInfo.Size = new System.Drawing.Size(312, 202);
            this.groupPlateInfo.TabIndex = 1;
            this.groupPlateInfo.TabStop = false;
            this.groupPlateInfo.Text = "Thông tin biển số";
            // 
            // btnSettingCamera
            // 
            this.btnSettingCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnSettingCamera.BackgroundImage = global::HeThongGiuXe.Properties.Resources.settings__1_;
            this.btnSettingCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettingCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingCamera.Location = new System.Drawing.Point(261, 41);
            this.btnSettingCamera.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettingCamera.Name = "btnSettingCamera";
            this.btnSettingCamera.Padding = new System.Windows.Forms.Padding(4);
            this.btnSettingCamera.Size = new System.Drawing.Size(40, 40);
            this.btnSettingCamera.TabIndex = 4;
            this.btnSettingCamera.UseVisualStyleBackColor = false;
            this.btnSettingCamera.Click += new System.EventHandler(this.btnSettingCamera_Click);
            // 
            // btnTryGetPlate
            // 
            this.btnTryGetPlate.BackColor = System.Drawing.Color.Transparent;
            this.btnTryGetPlate.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnTryGetPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTryGetPlate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnTryGetPlate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnTryGetPlate.FlatAppearance.BorderSize = 0;
            this.btnTryGetPlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryGetPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTryGetPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnTryGetPlate.Location = new System.Drawing.Point(78, 86);
            this.btnTryGetPlate.Margin = new System.Windows.Forms.Padding(4);
            this.btnTryGetPlate.Name = "btnTryGetPlate";
            this.btnTryGetPlate.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnTryGetPlate.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnTryGetPlate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTryGetPlate.Size = new System.Drawing.Size(172, 49);
            this.btnTryGetPlate.TabIndex = 3;
            this.btnTryGetPlate.Text = "Thử lại ";
            this.btnTryGetPlate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnTryGetPlate.UseVisualStyleBackColor = false;
            this.btnTryGetPlate.Click += new System.EventHandler(this.btnTryGetPlate_Click);
            // 
            // lbPlate
            // 
            this.lbPlate.Location = new System.Drawing.Point(20, 144);
            this.lbPlate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPlate.Name = "lbPlate";
            this.lbPlate.Size = new System.Drawing.Size(281, 34);
            this.lbPlate.TabIndex = 3;
            this.lbPlate.Text = "...";
            this.lbPlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlate
            // 
            this.txtPlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPlate.Location = new System.Drawing.Point(22, 41);
            this.txtPlate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.ReadOnly = true;
            this.txtPlate.Size = new System.Drawing.Size(228, 36);
            this.txtPlate.TabIndex = 0;
            this.txtPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlate.TextChanged += new System.EventHandler(this.txtPlate_TextChanged);
            // 
            // groupSaveInfo
            // 
            this.groupSaveInfo.Controls.Add(this.txtSavedPlate);
            this.groupSaveInfo.Controls.Add(this.btnSetingSerial);
            this.groupSaveInfo.Controls.Add(this.lbStatusCard);
            this.groupSaveInfo.Controls.Add(this.txtCard);
            this.groupSaveInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupSaveInfo.Location = new System.Drawing.Point(24, 44);
            this.groupSaveInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupSaveInfo.Name = "groupSaveInfo";
            this.groupSaveInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupSaveInfo.Size = new System.Drawing.Size(324, 202);
            this.groupSaveInfo.TabIndex = 0;
            this.groupSaveInfo.TabStop = false;
            this.groupSaveInfo.Text = "Thông tin check in";
            // 
            // txtSavedPlate
            // 
            this.txtSavedPlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtSavedPlate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSavedPlate.Enabled = false;
            this.txtSavedPlate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavedPlate.Location = new System.Drawing.Point(17, 44);
            this.txtSavedPlate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSavedPlate.Name = "txtSavedPlate";
            this.txtSavedPlate.Size = new System.Drawing.Size(250, 36);
            this.txtSavedPlate.TabIndex = 3;
            this.txtSavedPlate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetingSerial
            // 
            this.btnSetingSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnSetingSerial.BackgroundImage = global::HeThongGiuXe.Properties.Resources.settings__1_;
            this.btnSetingSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSetingSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetingSerial.Location = new System.Drawing.Point(275, 94);
            this.btnSetingSerial.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetingSerial.Name = "btnSetingSerial";
            this.btnSetingSerial.Padding = new System.Windows.Forms.Padding(4);
            this.btnSetingSerial.Size = new System.Drawing.Size(40, 40);
            this.btnSetingSerial.TabIndex = 2;
            this.btnSetingSerial.UseVisualStyleBackColor = false;
            this.btnSetingSerial.Click += new System.EventHandler(this.btnSetingSerial_Click);
            // 
            // lbStatusCard
            // 
            this.lbStatusCard.Location = new System.Drawing.Point(13, 151);
            this.lbStatusCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatusCard.Name = "lbStatusCard";
            this.lbStatusCard.Size = new System.Drawing.Size(254, 25);
            this.lbStatusCard.TabIndex = 1;
            this.lbStatusCard.Text = "...";
            this.lbStatusCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCard
            // 
            this.txtCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCard.Enabled = false;
            this.txtCard.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(15, 98);
            this.txtCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtCard.Name = "txtCard";
            this.txtCard.PasswordChar = '*';
            this.txtCard.Size = new System.Drawing.Size(252, 36);
            this.txtCard.TabIndex = 1;
            this.txtCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl
            // 
            this.groupControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.groupControl.Controls.Add(this.groupManageControll);
            this.groupControl.Controls.Add(this.groupConfirmControl);
            this.groupControl.Controls.Add(this.groupControlSOS);
            this.groupControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupControl.Location = new System.Drawing.Point(732, 30);
            this.groupControl.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl.Name = "groupControl";
            this.groupControl.Padding = new System.Windows.Forms.Padding(4);
            this.groupControl.Size = new System.Drawing.Size(583, 675);
            this.groupControl.TabIndex = 2;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Điều khiển";
            // 
            // groupManageControll
            // 
            this.groupManageControll.Controls.Add(this.btlGetAllInPark);
            this.groupManageControll.Controls.Add(this.btnFilterWithPlate);
            this.groupManageControll.Controls.Add(this.tableVehicleInPark);
            this.groupManageControll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupManageControll.Location = new System.Drawing.Point(24, 329);
            this.groupManageControll.Margin = new System.Windows.Forms.Padding(4);
            this.groupManageControll.Name = "groupManageControll";
            this.groupManageControll.Padding = new System.Windows.Forms.Padding(4);
            this.groupManageControll.Size = new System.Drawing.Size(545, 329);
            this.groupManageControll.TabIndex = 2;
            this.groupManageControll.TabStop = false;
            this.groupManageControll.Text = "Quản lí";
            // 
            // btlGetAllInPark
            // 
            this.btlGetAllInPark.BackColor = System.Drawing.Color.Transparent;
            this.btlGetAllInPark.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btlGetAllInPark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlGetAllInPark.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btlGetAllInPark.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btlGetAllInPark.FlatAppearance.BorderSize = 0;
            this.btlGetAllInPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlGetAllInPark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btlGetAllInPark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btlGetAllInPark.Location = new System.Drawing.Point(310, 41);
            this.btlGetAllInPark.Margin = new System.Windows.Forms.Padding(4);
            this.btlGetAllInPark.Name = "btlGetAllInPark";
            this.btlGetAllInPark.OnHoverBorderColor = System.Drawing.Color.White;
            this.btlGetAllInPark.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btlGetAllInPark.OnHoverTextColor = System.Drawing.Color.White;
            this.btlGetAllInPark.Size = new System.Drawing.Size(219, 57);
            this.btlGetAllInPark.TabIndex = 8;
            this.btlGetAllInPark.Text = "Xem xe trong bãi";
            this.btlGetAllInPark.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btlGetAllInPark.UseVisualStyleBackColor = false;
            this.btlGetAllInPark.Click += new System.EventHandler(this.btlGetAllInPark_Click);
            // 
            // btnFilterWithPlate
            // 
            this.btnFilterWithPlate.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterWithPlate.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnFilterWithPlate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilterWithPlate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnFilterWithPlate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnFilterWithPlate.FlatAppearance.BorderSize = 0;
            this.btnFilterWithPlate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterWithPlate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFilterWithPlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnFilterWithPlate.Location = new System.Drawing.Point(45, 41);
            this.btnFilterWithPlate.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilterWithPlate.Name = "btnFilterWithPlate";
            this.btnFilterWithPlate.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnFilterWithPlate.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnFilterWithPlate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFilterWithPlate.Size = new System.Drawing.Size(219, 57);
            this.btnFilterWithPlate.TabIndex = 7;
            this.btnFilterWithPlate.Text = "Xem theo biển số";
            this.btnFilterWithPlate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnFilterWithPlate.UseVisualStyleBackColor = false;
            this.btnFilterWithPlate.Click += new System.EventHandler(this.btnFilterWithPlate_Click);
            // 
            // tableVehicleInPark
            // 
            this.tableVehicleInPark.AllowUserToAddRows = false;
            this.tableVehicleInPark.AllowUserToDeleteRows = false;
            this.tableVehicleInPark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableVehicleInPark.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tableVehicleInPark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableVehicleInPark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVehicleInPark.Location = new System.Drawing.Point(19, 117);
            this.tableVehicleInPark.Margin = new System.Windows.Forms.Padding(4);
            this.tableVehicleInPark.Name = "tableVehicleInPark";
            this.tableVehicleInPark.ReadOnly = true;
            this.tableVehicleInPark.RowHeadersVisible = false;
            this.tableVehicleInPark.RowHeadersWidth = 51;
            this.tableVehicleInPark.RowTemplate.Height = 24;
            this.tableVehicleInPark.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableVehicleInPark.Size = new System.Drawing.Size(510, 193);
            this.tableVehicleInPark.TabIndex = 3;
            // 
            // groupConfirmControl
            // 
            this.groupConfirmControl.Controls.Add(this.btnConfirm);
            this.groupConfirmControl.Controls.Add(this.checkAutoCheckout);
            this.groupConfirmControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupConfirmControl.Location = new System.Drawing.Point(24, 164);
            this.groupConfirmControl.Margin = new System.Windows.Forms.Padding(4);
            this.groupConfirmControl.Name = "groupConfirmControl";
            this.groupConfirmControl.Padding = new System.Windows.Forms.Padding(4);
            this.groupConfirmControl.Size = new System.Drawing.Size(545, 157);
            this.groupConfirmControl.TabIndex = 1;
            this.groupConfirmControl.TabStop = false;
            this.groupConfirmControl.Text = "Xác nhận xe";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnConfirm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Azure;
            this.btnConfirm.Location = new System.Drawing.Point(45, 48);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnConfirm.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.Size = new System.Drawing.Size(219, 81);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xác nhận khớp \n     thông tin";
            this.btnConfirm.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // checkAutoCheckout
            // 
            this.checkAutoCheckout.AutoSize = true;
            this.checkAutoCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.checkAutoCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAutoCheckout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAutoCheckout.Location = new System.Drawing.Point(392, 57);
            this.checkAutoCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.checkAutoCheckout.Name = "checkAutoCheckout";
            this.checkAutoCheckout.Size = new System.Drawing.Size(107, 29);
            this.checkAutoCheckout.TabIndex = 3;
            this.checkAutoCheckout.Text = "Tự động";
            this.checkAutoCheckout.UseVisualStyleBackColor = false;
            // 
            // groupControlSOS
            // 
            this.groupControlSOS.Controls.Add(this.btnClose);
            this.groupControlSOS.Controls.Add(this.btnOpen);
            this.groupControlSOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupControlSOS.Location = new System.Drawing.Point(24, 31);
            this.groupControlSOS.Margin = new System.Windows.Forms.Padding(4);
            this.groupControlSOS.Name = "groupControlSOS";
            this.groupControlSOS.Padding = new System.Windows.Forms.Padding(4);
            this.groupControlSOS.Size = new System.Drawing.Size(545, 125);
            this.groupControlSOS.TabIndex = 0;
            this.groupControlSOS.TabStop = false;
            this.groupControlSOS.Text = "Điều khiển gấp";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnClose.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnClose.Location = new System.Drawing.Point(331, 43);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnClose.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(172, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng cổng";
            this.btnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnOpen.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOpen.Location = new System.Drawing.Point(45, 43);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnOpen.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpen.Size = new System.Drawing.Size(219, 49);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Mở cổng";
            this.btnOpen.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1329, 718);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.groupExtractInfo);
            this.Controls.Add(this.groupCamera);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều khiển xe ra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckoutForm_FormClosing);
            this.groupCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCamera)).EndInit();
            this.groupExtractInfo.ResumeLayout(false);
            this.groupPlateInfo.ResumeLayout(false);
            this.groupPlateInfo.PerformLayout();
            this.groupSaveInfo.ResumeLayout(false);
            this.groupSaveInfo.PerformLayout();
            this.groupControl.ResumeLayout(false);
            this.groupManageControll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleInPark)).EndInit();
            this.groupConfirmControl.ResumeLayout(false);
            this.groupConfirmControl.PerformLayout();
            this.groupControlSOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCamera;
        private System.Windows.Forms.GroupBox groupExtractInfo;
        private System.Windows.Forms.GroupBox groupPlateInfo;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.GroupBox groupSaveInfo;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.GroupBox groupManageControll;
        private System.Windows.Forms.DataGridView tableVehicleInPark;
        private System.Windows.Forms.GroupBox groupConfirmControl;
        private System.Windows.Forms.GroupBox groupControlSOS;
        private System.Windows.Forms.CheckBox checkAutoCheckout;
        private System.Windows.Forms.Label lbStatusCard;
        private Emgu.CV.UI.ImageBox imgCamera;
        private System.Windows.Forms.Button btnSetingSerial;
        private System.Windows.Forms.Label lbPlate;
        private System.Windows.Forms.TextBox txtSavedPlate;
        private DTO.RoundedButton btnTryGetPlate;
        private DTO.RoundedButton btlGetAllInPark;
        private DTO.RoundedButton btnFilterWithPlate;
        private DTO.RoundedButton btnConfirm;
        private DTO.RoundedButton btnClose;
        private DTO.RoundedButton btnOpen;
        private System.Windows.Forms.Button btnSettingCamera;
    }
}