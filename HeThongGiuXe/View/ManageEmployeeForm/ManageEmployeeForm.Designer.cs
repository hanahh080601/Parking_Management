
namespace HeThongGiuXe.View
{
    partial class ManageEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeeForm));
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.grbGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIDCardNumb = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.lbCardID = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbIDCardNumb = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.tableEmployees = new System.Windows.Forms.DataGridView();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.txtStudentIDFilter = new System.Windows.Forms.TextBox();
            this.txtFullnameFilter = new System.Windows.Forms.TextBox();
            this.lbEmployeeIdFilter = new System.Windows.Forms.Label();
            this.lbFullnameFilter = new System.Windows.Forms.Label();
            this.btnSearch = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnShowAll = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnCancel = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnReset = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnOK = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupInfo.SuspendLayout();
            this.grbGender.SuspendLayout();
            this.groupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployees)).BeginInit();
            this.groupControl.SuspendLayout();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.cbbRole);
            this.groupInfo.Controls.Add(this.dateTimePicker1);
            this.groupInfo.Controls.Add(this.lbBirthday);
            this.groupInfo.Controls.Add(this.grbGender);
            this.groupInfo.Controls.Add(this.txtUsername);
            this.groupInfo.Controls.Add(this.txtPassword);
            this.groupInfo.Controls.Add(this.txtIDCardNumb);
            this.groupInfo.Controls.Add(this.txtFullname);
            this.groupInfo.Controls.Add(this.lbCardID);
            this.groupInfo.Controls.Add(this.lbPassword);
            this.groupInfo.Controls.Add(this.lbUsername);
            this.groupInfo.Controls.Add(this.lbIDCardNumb);
            this.groupInfo.Controls.Add(this.lbFullname);
            this.groupInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupInfo.Location = new System.Drawing.Point(26, 13);
            this.groupInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupInfo.Size = new System.Drawing.Size(478, 323);
            this.groupInfo.TabIndex = 1;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Thông tin";
            // 
            // cbbRole
            // 
            this.cbbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.cbbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Location = new System.Drawing.Point(161, 281);
            this.cbbRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(285, 27);
            this.cbbRole.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(35, 128);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(75, 19);
            this.lbBirthday.TabIndex = 19;
            this.lbBirthday.Text = "Ngày sinh";
            // 
            // grbGender
            // 
            this.grbGender.Controls.Add(this.rdbFemale);
            this.grbGender.Controls.Add(this.rdbMale);
            this.grbGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.grbGender.Location = new System.Drawing.Point(26, 56);
            this.grbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbGender.Name = "grbGender";
            this.grbGender.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbGender.Size = new System.Drawing.Size(420, 58);
            this.grbGender.TabIndex = 18;
            this.grbGender.TabStop = false;
            this.grbGender.Text = "Giới tính";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(288, 27);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(47, 23);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(135, 27);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(59, 23);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.txtUsername.Location = new System.Drawing.Point(161, 204);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 22);
            this.txtUsername.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.txtPassword.Location = new System.Drawing.Point(161, 242);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(285, 22);
            this.txtPassword.TabIndex = 15;
            // 
            // txtIDCardNumb
            // 
            this.txtIDCardNumb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtIDCardNumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCardNumb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCardNumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.txtIDCardNumb.Location = new System.Drawing.Point(161, 162);
            this.txtIDCardNumb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDCardNumb.Name = "txtIDCardNumb";
            this.txtIDCardNumb.Size = new System.Drawing.Size(285, 22);
            this.txtIDCardNumb.TabIndex = 13;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.txtFullname.Location = new System.Drawing.Point(161, 26);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(285, 22);
            this.txtFullname.TabIndex = 10;
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Location = new System.Drawing.Point(35, 284);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(62, 19);
            this.lbCardID.TabIndex = 9;
            this.lbCardID.Text = "Chức vụ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(35, 244);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(71, 19);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(35, 206);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(98, 19);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Tên tài khoản";
            // 
            // lbIDCardNumb
            // 
            this.lbIDCardNumb.AutoSize = true;
            this.lbIDCardNumb.Location = new System.Drawing.Point(35, 165);
            this.lbIDCardNumb.Name = "lbIDCardNumb";
            this.lbIDCardNumb.Size = new System.Drawing.Size(73, 19);
            this.lbIDCardNumb.TabIndex = 6;
            this.lbIDCardNumb.Text = "Số CMND";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(35, 29);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(94, 19);
            this.lbFullname.TabIndex = 2;
            this.lbFullname.Text = "Họ và tên (*)";
            // 
            // groupList
            // 
            this.groupList.Controls.Add(this.tableEmployees);
            this.groupList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupList.Location = new System.Drawing.Point(26, 356);
            this.groupList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupList.Name = "groupList";
            this.groupList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupList.Size = new System.Drawing.Size(1186, 302);
            this.groupList.TabIndex = 5;
            this.groupList.TabStop = false;
            this.groupList.Text = "Danh sách";
            // 
            // tableEmployees
            // 
            this.tableEmployees.AllowUserToAddRows = false;
            this.tableEmployees.AllowUserToDeleteRows = false;
            this.tableEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tableEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEmployees.Location = new System.Drawing.Point(10, 30);
            this.tableEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableEmployees.Name = "tableEmployees";
            this.tableEmployees.ReadOnly = true;
            this.tableEmployees.RowHeadersWidth = 51;
            this.tableEmployees.RowTemplate.Height = 24;
            this.tableEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableEmployees.Size = new System.Drawing.Size(1170, 252);
            this.tableEmployees.TabIndex = 0;
            this.tableEmployees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableEmployees_RowHeaderMouseClick);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.btnCancel);
            this.groupControl.Controls.Add(this.btnReset);
            this.groupControl.Controls.Add(this.btnOK);
            this.groupControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupControl.Location = new System.Drawing.Point(530, 13);
            this.groupControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl.Name = "groupControl";
            this.groupControl.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl.Size = new System.Drawing.Size(248, 323);
            this.groupControl.TabIndex = 2;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Thao tác";
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.btnSearch);
            this.groupFilter.Controls.Add(this.btnShowAll);
            this.groupFilter.Controls.Add(this.txtStudentIDFilter);
            this.groupFilter.Controls.Add(this.txtFullnameFilter);
            this.groupFilter.Controls.Add(this.lbEmployeeIdFilter);
            this.groupFilter.Controls.Add(this.lbFullnameFilter);
            this.groupFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupFilter.Location = new System.Drawing.Point(806, 13);
            this.groupFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupFilter.Size = new System.Drawing.Size(400, 323);
            this.groupFilter.TabIndex = 4;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Tìm kiếm";
            // 
            // txtStudentIDFilter
            // 
            this.txtStudentIDFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtStudentIDFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentIDFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentIDFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.txtStudentIDFilter.Location = new System.Drawing.Point(141, 103);
            this.txtStudentIDFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentIDFilter.Name = "txtStudentIDFilter";
            this.txtStudentIDFilter.Size = new System.Drawing.Size(223, 22);
            this.txtStudentIDFilter.TabIndex = 9;
            // 
            // txtFullnameFilter
            // 
            this.txtFullnameFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtFullnameFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullnameFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullnameFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.txtFullnameFilter.Location = new System.Drawing.Point(141, 38);
            this.txtFullnameFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullnameFilter.Name = "txtFullnameFilter";
            this.txtFullnameFilter.Size = new System.Drawing.Size(225, 22);
            this.txtFullnameFilter.TabIndex = 6;
            // 
            // lbEmployeeIdFilter
            // 
            this.lbEmployeeIdFilter.AutoSize = true;
            this.lbEmployeeIdFilter.Location = new System.Drawing.Point(46, 106);
            this.lbEmployeeIdFilter.Name = "lbEmployeeIdFilter";
            this.lbEmployeeIdFilter.Size = new System.Drawing.Size(73, 19);
            this.lbEmployeeIdFilter.TabIndex = 4;
            this.lbEmployeeIdFilter.Text = "Số CMND";
            // 
            // lbFullnameFilter
            // 
            this.lbFullnameFilter.AutoSize = true;
            this.lbFullnameFilter.Location = new System.Drawing.Point(45, 41);
            this.lbFullnameFilter.Name = "lbFullnameFilter";
            this.lbFullnameFilter.Size = new System.Drawing.Size(74, 19);
            this.lbFullnameFilter.TabIndex = 0;
            this.lbFullnameFilter.Text = "Họ và tên";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnSearch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSearch.Location = new System.Drawing.Point(49, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(317, 54);
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
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShowAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.Location = new System.Drawing.Point(49, 242);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnShowAll.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.Size = new System.Drawing.Size(317, 54);
            this.btnShowAll.TabIndex = 25;
            this.btnShowAll.Text = "Xem tất cả";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnCancel.Location = new System.Drawing.Point(33, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(182, 54);
            this.btnCancel.TabIndex = 24;
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
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnReset.Location = new System.Drawing.Point(33, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnReset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.Size = new System.Drawing.Size(182, 52);
            this.btnReset.TabIndex = 23;
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
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.Location = new System.Drawing.Point(33, 41);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnOK.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.Size = new System.Drawing.Size(182, 54);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "Thêm";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1224, 690);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.groupControl);
            this.Controls.Add(this.groupInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.grbGender.ResumeLayout(false);
            this.grbGender.PerformLayout();
            this.groupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployees)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtIDCardNumb;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label lbCardID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbIDCardNumb;
        private System.Windows.Forms.Label lbFullname;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.TextBox txtStudentIDFilter;
        private System.Windows.Forms.TextBox txtFullnameFilter;
        private System.Windows.Forms.Label lbEmployeeIdFilter;
        private System.Windows.Forms.Label lbFullnameFilter;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.DataGridView tableEmployees;
        private System.Windows.Forms.GroupBox grbGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.ComboBox cbbRole;
        private DTO.RoundedButton btnCancel;
        private DTO.RoundedButton btnReset;
        private DTO.RoundedButton btnOK;
        private DTO.RoundedButton btnSearch;
        private DTO.RoundedButton btnShowAll;
    }
}