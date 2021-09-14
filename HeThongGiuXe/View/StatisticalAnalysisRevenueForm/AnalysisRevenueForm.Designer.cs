
namespace HeThongGiuXe.View
{
    partial class AnalysisRevenueForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisRevenueForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_export_pdf = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_analysis = new HeThongGiuXe.DTO.RoundedButton(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtpk_year = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgv_list_revenue = new System.Windows.Forms.DataGridView();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_revenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1335, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_export_pdf);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox3.Location = new System.Drawing.Point(672, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 119);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hành động";
            // 
            // btn_export_pdf
            // 
            this.btn_export_pdf.BackColor = System.Drawing.Color.Transparent;
            this.btn_export_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_export_pdf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.btn_export_pdf.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_export_pdf.FlatAppearance.BorderSize = 0;
            this.btn_export_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export_pdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_export_pdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.btn_export_pdf.Location = new System.Drawing.Point(240, 41);
            this.btn_export_pdf.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_export_pdf.Name = "btn_export_pdf";
            this.btn_export_pdf.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_export_pdf.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_export_pdf.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_export_pdf.Size = new System.Drawing.Size(193, 51);
            this.btn_export_pdf.TabIndex = 7;
            this.btn_export_pdf.Text = "Xuất báo";
            this.btn_export_pdf.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_export_pdf.UseVisualStyleBackColor = false;
            this.btn_export_pdf.Click += new System.EventHandler(this.btn_export_pdf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_analysis);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpk_year);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox2.Location = new System.Drawing.Point(16, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân tích";
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
            this.btn_analysis.Location = new System.Drawing.Point(418, 42);
            this.btn_analysis.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_analysis.Name = "btn_analysis";
            this.btn_analysis.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_analysis.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btn_analysis.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btn_analysis.Size = new System.Drawing.Size(193, 51);
            this.btn_analysis.TabIndex = 7;
            this.btn_analysis.Text = "Phân tích";
            this.btn_analysis.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.btn_analysis.UseVisualStyleBackColor = false;
            this.btn_analysis.Click += new System.EventHandler(this.btn_analysis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Năm";
            // 
            // dtpk_year
            // 
            this.dtpk_year.CustomFormat = "yyyy";
            this.dtpk_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_year.Location = new System.Drawing.Point(124, 48);
            this.dtpk_year.Name = "dtpk_year";
            this.dtpk_year.ShowUpDown = true;
            this.dtpk_year.Size = new System.Drawing.Size(200, 34);
            this.dtpk_year.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtgv_list_revenue);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox4.Location = new System.Drawing.Point(12, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(660, 503);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dtgv_list_revenue
            // 
            this.dtgv_list_revenue.AllowUserToAddRows = false;
            this.dtgv_list_revenue.AllowUserToDeleteRows = false;
            this.dtgv_list_revenue.AllowUserToResizeRows = false;
            this.dtgv_list_revenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_list_revenue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.dtgv_list_revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_list_revenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_list_revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_list_revenue.Location = new System.Drawing.Point(18, 44);
            this.dtgv_list_revenue.Name = "dtgv_list_revenue";
            this.dtgv_list_revenue.ReadOnly = true;
            this.dtgv_list_revenue.RowHeadersVisible = false;
            this.dtgv_list_revenue.RowHeadersWidth = 51;
            this.dtgv_list_revenue.RowTemplate.Height = 24;
            this.dtgv_list_revenue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_list_revenue.Size = new System.Drawing.Size(624, 443);
            this.dtgv_list_revenue.TabIndex = 0;
            this.dtgv_list_revenue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgv_list_revenue_MouseDoubleClick);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.chart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Revenue";
            legend2.Name = "NumberVehicles";
            this.chart.Legends.Add(legend1);
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(12, 44);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart.Size = new System.Drawing.Size(639, 443);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.groupBox5.Location = new System.Drawing.Point(684, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(663, 503);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Biểu đồ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // AnalysisRevenueForm
            // 
            this.AcceptButton = this.btn_analysis;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1363, 672);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(248)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnalysisRevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_list_revenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk_year;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtgv_list_revenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private DTO.RoundedButton btn_export_pdf;
        private DTO.RoundedButton btn_analysis;
    }
}