
namespace HeThongGiuXe.View
{
    partial class ManageUnitPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUnitPrice));
            this.groupDayPrice = new System.Windows.Forms.GroupBox();
            this.tableDayPrice = new System.Windows.Forms.DataGridView();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.groupSpecicalTime = new System.Windows.Forms.GroupBox();
            this.tableSpecialPrice = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.dateFilter = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbStartFilter = new System.Windows.Forms.Label();
            this.btnDelete = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnReset = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnOK = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnSearch = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnShowAll = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.btnSaveChange = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupDayPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDayPrice)).BeginInit();
            this.groupSpecicalTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSpecialPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDayPrice
            // 
            this.groupDayPrice.Controls.Add(this.btnSaveChange);
            this.groupDayPrice.Controls.Add(this.tableDayPrice);
            this.groupDayPrice.Controls.Add(this.cbDay);
            this.groupDayPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupDayPrice.Location = new System.Drawing.Point(12, 21);
            this.groupDayPrice.Name = "groupDayPrice";
            this.groupDayPrice.Size = new System.Drawing.Size(381, 606);
            this.groupDayPrice.TabIndex = 0;
            this.groupDayPrice.TabStop = false;
            this.groupDayPrice.Text = "Đơn giá hàng ngày";
            // 
            // tableDayPrice
            // 
            this.tableDayPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDayPrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tableDayPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDayPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDayPrice.Location = new System.Drawing.Point(18, 105);
            this.tableDayPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tableDayPrice.Name = "tableDayPrice";
            this.tableDayPrice.RowHeadersVisible = false;
            this.tableDayPrice.RowHeadersWidth = 51;
            this.tableDayPrice.RowTemplate.Height = 24;
            this.tableDayPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableDayPrice.Size = new System.Drawing.Size(346, 482);
            this.tableDayPrice.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.ForeColor = System.Drawing.SystemColors.Window;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Chủ nhật",
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7"});
            this.cbDay.Location = new System.Drawing.Point(18, 49);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(170, 33);
            this.cbDay.TabIndex = 1;
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // groupSpecicalTime
            // 
            this.groupSpecicalTime.Controls.Add(this.btnDelete);
            this.groupSpecicalTime.Controls.Add(this.btnReset);
            this.groupSpecicalTime.Controls.Add(this.btnOK);
            this.groupSpecicalTime.Controls.Add(this.btnSearch);
            this.groupSpecicalTime.Controls.Add(this.btnShowAll);
            this.groupSpecicalTime.Controls.Add(this.tableSpecialPrice);
            this.groupSpecicalTime.Controls.Add(this.txtDescription);
            this.groupSpecicalTime.Controls.Add(this.lbDescription);
            this.groupSpecicalTime.Controls.Add(this.dateFilter);
            this.groupSpecicalTime.Controls.Add(this.dateStart);
            this.groupSpecicalTime.Controls.Add(this.dateEnd);
            this.groupSpecicalTime.Controls.Add(this.txtPrice);
            this.groupSpecicalTime.Controls.Add(this.lbPrice);
            this.groupSpecicalTime.Controls.Add(this.lbEnd);
            this.groupSpecicalTime.Controls.Add(this.lbStart);
            this.groupSpecicalTime.Controls.Add(this.lbStartFilter);
            this.groupSpecicalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupSpecicalTime.Location = new System.Drawing.Point(399, 21);
            this.groupSpecicalTime.Name = "groupSpecicalTime";
            this.groupSpecicalTime.Size = new System.Drawing.Size(445, 606);
            this.groupSpecicalTime.TabIndex = 1;
            this.groupSpecicalTime.TabStop = false;
            this.groupSpecicalTime.Text = "Giá thời gian đặt biệt";
            // 
            // tableSpecialPrice
            // 
            this.tableSpecialPrice.AllowUserToAddRows = false;
            this.tableSpecialPrice.AllowUserToDeleteRows = false;
            this.tableSpecialPrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableSpecialPrice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.tableSpecialPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableSpecialPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSpecialPrice.Location = new System.Drawing.Point(24, 383);
            this.tableSpecialPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tableSpecialPrice.Name = "tableSpecialPrice";
            this.tableSpecialPrice.ReadOnly = true;
            this.tableSpecialPrice.RowHeadersVisible = false;
            this.tableSpecialPrice.RowHeadersWidth = 51;
            this.tableSpecialPrice.RowTemplate.Height = 24;
            this.tableSpecialPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableSpecialPrice.Size = new System.Drawing.Size(396, 204);
            this.tableSpecialPrice.TabIndex = 4;
            this.tableSpecialPrice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableSpecialPrice_CellClick);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(185, 152);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 25);
            this.txtDescription.TabIndex = 16;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescription.Location = new System.Drawing.Point(93, 152);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(77, 25);
            this.lbDescription.TabIndex = 15;
            this.lbDescription.Text = "Ghi chú";
            // 
            // dateFilter
            // 
            this.dateFilter.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dateFilter.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dateFilter.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dateFilter.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dateFilter.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFilter.Location = new System.Drawing.Point(185, 282);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(235, 32);
            this.dateFilter.TabIndex = 10;
            // 
            // dateStart
            // 
            this.dateStart.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dateStart.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(184, 39);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(236, 32);
            this.dateStart.TabIndex = 8;
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(184, 78);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(236, 32);
            this.dateEnd.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Location = new System.Drawing.Point(184, 121);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 25);
            this.txtPrice.TabIndex = 6;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(90, 121);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(80, 25);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Đơn giá";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnd.Location = new System.Drawing.Point(36, 84);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(133, 25);
            this.lbEnd.TabIndex = 4;
            this.lbEnd.Text = "Ngày kết thúc";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStart.Location = new System.Drawing.Point(40, 45);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(129, 25);
            this.lbStart.TabIndex = 3;
            this.lbStart.Text = "Ngày bắt đầu";
            // 
            // lbStartFilter
            // 
            this.lbStartFilter.AutoSize = true;
            this.lbStartFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartFilter.Location = new System.Drawing.Point(41, 288);
            this.lbStartFilter.Name = "lbStartFilter";
            this.lbStartFilter.Size = new System.Drawing.Size(129, 25);
            this.lbStartFilter.TabIndex = 1;
            this.lbStartFilter.Text = "Ngày bắt đầu";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnDelete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnDelete.Location = new System.Drawing.Point(319, 198);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.Size = new System.Drawing.Size(101, 46);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnReset.Location = new System.Drawing.Point(171, 198);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnReset.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.Size = new System.Drawing.Size(112, 46);
            this.btnReset.TabIndex = 29;
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
            this.btnOK.Location = new System.Drawing.Point(24, 198);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnOK.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnOK.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOK.Size = new System.Drawing.Size(109, 46);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "Thêm";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.btnSearch.Location = new System.Drawing.Point(262, 327);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.Size = new System.Drawing.Size(158, 48);
            this.btnSearch.TabIndex = 27;
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
            this.btnShowAll.Location = new System.Drawing.Point(41, 327);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnShowAll.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnShowAll.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowAll.Size = new System.Drawing.Size(172, 48);
            this.btnShowAll.TabIndex = 26;
            this.btnShowAll.Text = "Xem tất cả";
            this.btnShowAll.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveChange.BackgroundImage = global::HeThongGiuXe.Properties.Resources.icons8_automatic_96;
            this.btnSaveChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveChange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btnSaveChange.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnSaveChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSaveChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSaveChange.Location = new System.Drawing.Point(205, 41);
            this.btnSaveChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSaveChange.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(163)))), ((int)(((byte)(177)))));
            this.btnSaveChange.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveChange.Size = new System.Drawing.Size(159, 45);
            this.btnSaveChange.TabIndex = 20;
            this.btnSaveChange.Text = "Lưu thay đổi";
            this.btnSaveChange.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // ManageUnitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(858, 649);
            this.Controls.Add(this.groupSpecicalTime);
            this.Controls.Add(this.groupDayPrice);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageUnitPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí đơn giá";
            this.groupDayPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDayPrice)).EndInit();
            this.groupSpecicalTime.ResumeLayout(false);
            this.groupSpecicalTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableSpecialPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDayPrice;
        private System.Windows.Forms.GroupBox groupSpecicalTime;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.DateTimePicker dateFilter;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbStartFilter;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.DataGridView tableSpecialPrice;
        private DTO.RoundedButton btnSaveChange;
        private DTO.RoundedButton btnShowAll;
        private DTO.RoundedButton btnSearch;
        private DTO.RoundedButton btnOK;
        private DTO.RoundedButton btnReset;
        private DTO.RoundedButton btnDelete;
        private System.Windows.Forms.DataGridView tableDayPrice;
    }
}