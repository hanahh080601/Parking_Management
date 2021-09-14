
namespace HeThongGiuXe.View
{
    partial class ManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.btnCancel = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnReset = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnOK = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbCardID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.tableCustomers = new System.Windows.Forms.DataGridView();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnShowAll = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.txtStudentIDFilter = new System.Windows.Forms.TextBox();
            this.txtEmailFilter = new System.Windows.Forms.TextBox();
            this.txtPhoneFilter = new System.Windows.Forms.TextBox();
            this.txtFullnameFilter = new System.Windows.Forms.TextBox();
            this.lbStudentIdFilter = new System.Windows.Forms.Label();
            this.lbEmailFilter = new System.Windows.Forms.Label();
            this.lbPhoneFilter = new System.Windows.Forms.Label();
            this.lbFullnameFilter = new System.Windows.Forms.Label();
            this.groupInfo.SuspendLayout();
            this.groupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).BeginInit();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.btnCancel);
            this.groupInfo.Controls.Add(this.btnReset);
            this.groupInfo.Controls.Add(this.btnOK);
            this.groupInfo.Controls.Add(this.cbPort);
            this.groupInfo.Controls.Add(this.txtCardID);
            this.groupInfo.Controls.Add(this.txtPassword);
            this.groupInfo.Controls.Add(this.txtUsername);
            this.groupInfo.Controls.Add(this.txtStudentID);
            this.groupInfo.Controls.Add(this.txtEmail);
            this.groupInfo.Controls.Add(this.txtPhone);
            this.groupInfo.Controls.Add(this.txtFullname);
            this.groupInfo.Controls.Add(this.lbCardID);
            this.groupInfo.Controls.Add(this.lbPassword);
            this.groupInfo.Controls.Add(this.lbUsername);
            this.groupInfo.Controls.Add(this.lbStudentID);
            this.groupInfo.Controls.Add(this.lbEmail);
            this.groupInfo.Controls.Add(this.lbPhone);
            this.groupInfo.Controls.Add(this.lbFullname);
            this.groupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupInfo.Location = new System.Drawing.Point(29, 22);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(712, 282);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCancel.Location = new System.Drawing.Point(478, 218);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(119, 46);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Xóa";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnReset.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnReset.Location = new System.Drawing.Point(301, 218);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnReset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.Size = new System.Drawing.Size(128, 46);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.Location = new System.Drawing.Point(116, 218);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnOK.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.Size = new System.Drawing.Size(117, 46);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "Thêm";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbPort
            // 
            this.cbPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.ForeColor = System.Drawing.SystemColors.Window;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(503, 159);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(188, 33);
            this.cbPort.TabIndex = 17;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // txtCardID
            // 
            this.txtCardID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtCardID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCardID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCardID.Location = new System.Drawing.Point(503, 122);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.PasswordChar = '*';
            this.txtCardID.ReadOnly = true;
            this.txtCardID.Size = new System.Drawing.Size(188, 25);
            this.txtCardID.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(143, 162);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 25);
            this.txtPassword.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsername.Location = new System.Drawing.Point(143, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 25);
            this.txtUsername.TabIndex = 14;
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStudentID.Location = new System.Drawing.Point(503, 81);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(188, 25);
            this.txtStudentID.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(143, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(503, 43);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(188, 25);
            this.txtPhone.TabIndex = 11;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullname.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFullname.Location = new System.Drawing.Point(143, 41);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(192, 25);
            this.txtFullname.TabIndex = 10;
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Location = new System.Drawing.Point(399, 122);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(98, 25);
            this.lbCardID.TabIndex = 9;
            this.lbCardID.Text = "Mã thẻ từ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(41, 162);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(96, 25);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(11, 125);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(131, 25);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Tên tài khoản";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(349, 81);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(148, 25);
            this.lbStudentID.TabIndex = 6;
            this.lbStudentID.Text = "Mã số sinh viên";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(83, 82);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(54, 25);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Emai";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(368, 43);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(129, 25);
            this.lbPhone.TabIndex = 3;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(11, 43);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(126, 25);
            this.lbFullname.TabIndex = 2;
            this.lbFullname.Text = "Họ và tên (*)";
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.tableCustomers);
            this.groupList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupList.Location = new System.Drawing.Point(29, 310);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(1106, 297);
            this.groupList.TabIndex = 2;
            this.groupList.TabStop = false;
            this.groupList.Text = "Danh sách";
            // 
            // tableCustomers
            // 
            this.tableCustomers.AllowUserToAddRows = false;
            this.tableCustomers.AllowUserToDeleteRows = false;
            this.tableCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tableCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCustomers.Location = new System.Drawing.Point(16, 31);
            this.tableCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tableCustomers.Name = "tableCustomers";
            this.tableCustomers.ReadOnly = true;
            this.tableCustomers.RowHeadersWidth = 51;
            this.tableCustomers.RowTemplate.Height = 24;
            this.tableCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableCustomers.Size = new System.Drawing.Size(1069, 247);
            this.tableCustomers.TabIndex = 4;
            this.tableCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableCustomers_RowHeaderMouseClick);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.btnShowAll);
            this.groupFilter.Controls.Add(this.txtStudentIDFilter);
            this.groupFilter.Controls.Add(this.txtEmailFilter);
            this.groupFilter.Controls.Add(this.txtPhoneFilter);
            this.groupFilter.Controls.Add(this.txtFullnameFilter);
            this.groupFilter.Controls.Add(this.lbStudentIdFilter);
            this.groupFilter.Controls.Add(this.lbEmailFilter);
            this.groupFilter.Controls.Add(this.lbPhoneFilter);
            this.groupFilter.Controls.Add(this.lbFullnameFilter);
            this.groupFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupFilter.Location = new System.Drawing.Point(747, 22);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(388, 282);
            this.groupFilter.TabIndex = 3;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnSearch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.Location = new System.Drawing.Point(208, 218);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(149, 46);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAll.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnShowAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnShowAll.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.Location = new System.Drawing.Point(41, 218);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnShowAll.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.Size = new System.Drawing.Size(148, 46);
            this.btnShowAll.TabIndex = 25;
            this.btnShowAll.Text = "Xem tất cả";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtStudentIDFilter
            // 
            this.txtStudentIDFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtStudentIDFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentIDFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStudentIDFilter.Location = new System.Drawing.Point(166, 125);
            this.txtStudentIDFilter.Name = "txtStudentIDFilter";
            this.txtStudentIDFilter.Size = new System.Drawing.Size(201, 25);
            this.txtStudentIDFilter.TabIndex = 23;
            // 
            // txtEmailFilter
            // 
            this.txtEmailFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtEmailFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmailFilter.Location = new System.Drawing.Point(166, 82);
            this.txtEmailFilter.Name = "txtEmailFilter";
            this.txtEmailFilter.Size = new System.Drawing.Size(201, 25);
            this.txtEmailFilter.TabIndex = 22;
            // 
            // txtPhoneFilter
            // 
            this.txtPhoneFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtPhoneFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhoneFilter.Location = new System.Drawing.Point(166, 171);
            this.txtPhoneFilter.Name = "txtPhoneFilter";
            this.txtPhoneFilter.Size = new System.Drawing.Size(201, 25);
            this.txtPhoneFilter.TabIndex = 24;
            // 
            // txtFullnameFilter
            // 
            this.txtFullnameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtFullnameFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullnameFilter.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFullnameFilter.Location = new System.Drawing.Point(166, 41);
            this.txtFullnameFilter.Name = "txtFullnameFilter";
            this.txtFullnameFilter.Size = new System.Drawing.Size(201, 25);
            this.txtFullnameFilter.TabIndex = 21;
            // 
            // lbStudentIdFilter
            // 
            this.lbStudentIdFilter.AutoSize = true;
            this.lbStudentIdFilter.Location = new System.Drawing.Point(84, 125);
            this.lbStudentIdFilter.Name = "lbStudentIdFilter";
            this.lbStudentIdFilter.Size = new System.Drawing.Size(65, 25);
            this.lbStudentIdFilter.TabIndex = 4;
            this.lbStudentIdFilter.Text = "Mã số";
            // 
            // lbEmailFilter
            // 
            this.lbEmailFilter.AutoSize = true;
            this.lbEmailFilter.Location = new System.Drawing.Point(90, 81);
            this.lbEmailFilter.Name = "lbEmailFilter";
            this.lbEmailFilter.Size = new System.Drawing.Size(59, 25);
            this.lbEmailFilter.TabIndex = 2;
            this.lbEmailFilter.Text = "Email";
            // 
            // lbPhoneFilter
            // 
            this.lbPhoneFilter.AutoSize = true;
            this.lbPhoneFilter.Location = new System.Drawing.Point(20, 171);
            this.lbPhoneFilter.Name = "lbPhoneFilter";
            this.lbPhoneFilter.Size = new System.Drawing.Size(129, 25);
            this.lbPhoneFilter.TabIndex = 1;
            this.lbPhoneFilter.Text = "Số điện thoại";
            // 
            // lbFullnameFilter
            // 
            this.lbFullnameFilter.AutoSize = true;
            this.lbFullnameFilter.Location = new System.Drawing.Point(51, 41);
            this.lbFullnameFilter.Name = "lbFullnameFilter";
            this.lbFullnameFilter.Size = new System.Drawing.Size(98, 25);
            this.lbFullnameFilter.TabIndex = 0;
            this.lbFullnameFilter.Text = "Họ và tên";
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1147, 633);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.groupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCustomers)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.TextBox txtStudentIDFilter;
        private System.Windows.Forms.TextBox txtEmailFilter;
        private System.Windows.Forms.TextBox txtPhoneFilter;
        private System.Windows.Forms.TextBox txtFullnameFilter;
        private System.Windows.Forms.Label lbStudentIdFilter;
        private System.Windows.Forms.Label lbEmailFilter;
        private System.Windows.Forms.Label lbPhoneFilter;
        private System.Windows.Forms.Label lbFullnameFilter;
        private System.Windows.Forms.ComboBox cbPort;
        private DTO.RoundedButton btnOK;
        private DTO.RoundedButton btnReset;
        private DTO.RoundedButton btnCancel;
        private System.Windows.Forms.DataGridView tableCustomers;
        private DTO.RoundedButton btnSearch;
        private DTO.RoundedButton btnShowAll;
    }
}