using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeThongGiuXe.BLL;
using System.Windows.Forms.DataVisualization.Charting;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.IO.Font.Constants;
using iText.IO.Font;

namespace HeThongGiuXe.View
{

    public partial class AnalysisRevenueForm : Form
    {
        public AnalysisRevenueForm()
        {
            InitializeComponent();
            this.chart.Series.Add(ChartSeriesEnum.REVENUE_PAYMENT_AT_PARKING);
            this.chart.Series.Add(ChartSeriesEnum.REVENUE_PACKAGE);
            this.chart.Series.Add(ChartSeriesEnum.TOTAL_REVENUE);
            LoadDTable();
        }

        private void LoadDTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn(AnalysDTableColumnEnum.MONTH, typeof(string)),
                new DataColumn(AnalysDTableColumnEnum.NUM_VEHICLES, typeof(int)),
                new DataColumn(AnalysDTableColumnEnum.REVENUE_PACKAGE, typeof(int)),
                new DataColumn(AnalysDTableColumnEnum.REVENUE_PAYMENT_AT_PARKING, typeof(int)),
                new DataColumn(AnalysDTableColumnEnum.REVENUE, typeof(string))
            });

            this.dtgv_list_revenue.DataSource = dt;
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(this.dtpk_year.Value.Year);
            this.dtgv_list_revenue.DataSource = AnalysisRevenueBLL.Instance().GetDataTableRevenue(year);
            FillChart();
        }

        private void btn_show_chart_Click(object sender, EventArgs e)
        {
            
        }

        private void FillChart()
        {
            ClearChart();

            DataTable data = (DataTable)this.dtgv_list_revenue.DataSource;

            foreach (DataRow dr in data.Rows)
            {
                this.chart.Series[ChartSeriesEnum.REVENUE_PACKAGE]
                    .Points.AddXY(dr[AnalysDTableColumnEnum.MONTH], dr[AnalysDTableColumnEnum.REVENUE_PACKAGE]);

                this.chart.Series[ChartSeriesEnum.REVENUE_PAYMENT_AT_PARKING]
                    .Points.AddXY(dr[AnalysDTableColumnEnum.MONTH], dr[AnalysDTableColumnEnum.REVENUE_PAYMENT_AT_PARKING]);

                this.chart.Series[ChartSeriesEnum.TOTAL_REVENUE]
                    .Points.AddXY(dr[AnalysDTableColumnEnum.MONTH], dr[AnalysDTableColumnEnum.REVENUE]);

            }

            this.chart.DataBind();
        }

        private void ClearChart()
        {
            foreach(var series in this.chart.Series)
            {
                series.Points.Clear();
            }
        }

        private void btn_export_pdf_Click(object sender, EventArgs e)
        {

            if (this.dtgv_list_revenue.Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất. Vui lòng phân tích dữ liệu trước");
                return;
            }
            // Select folder
            String dir = SelectFolder();
            if (dir == null)
            {
                return;
            }

            string fileName = dir + @"\report_" + DateTime.Now.ToString().Replace("/", "_").Replace(" ", "_").Replace(":", "_") + ".pdf";
            //string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            //string fontDirectory = string.Format("{0}Resources\\font\\times-new-roman.ttf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            //FontProgram fontProgram = FontProgramFactory.CreateFont(fontDirectory);
            //PdfFont font = PdfFontFactory.CreateFont(fontProgram);
            PdfWriter writer = new PdfWriter(fileName);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            //document.SetFontFamily("Times New Roman");
            //document.SetFont(font);

            document.Add(new Paragraph("BAO CAO DOANH THU")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20));
            document.Add(new Paragraph(new Text("\n")));

            Table table = new Table(this.dtgv_list_revenue.Columns.Count, false);

            int i = 1;
            foreach(DataGridViewColumn column in this.dtgv_list_revenue.Columns)
            {
                Cell cell = new Cell(1, 1)
                            .SetBackgroundColor(ColorConstants.BLUE)
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph(column.HeaderText));
                table.AddCell(cell);
                i++;
            }

            foreach (DataGridViewRow row in this.dtgv_list_revenue.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    Cell cell = new Cell().Add(new Paragraph(c.Value.ToString()));
                    table.AddCell(cell);
                }
            }

            document.Add(table.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
            document.Add(new Paragraph(new Text("\n")));

            
            using (MemoryStream stream = new MemoryStream())
            {
                this.chart.SaveImage(stream, ChartImageFormat.Png);

                ImageData img = ImageDataFactory.Create(stream.GetBuffer(), false);

                document.Add(new Image(img).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER));
                
                stream.Close();
            }


            document.Close();
            MessageBox.Show("Đã export file PDF thành công. Vui lòng check file: " + fileName);
        }

        private void dtgv_list_revenue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.dtgv_list_revenue.SelectedRows.Count > 0)
            {
                int year = Convert.ToInt32(this.dtpk_year.Value.Year);
                int month = Convert.ToInt32(this.dtgv_list_revenue.SelectedRows[0].Cells[AnalysDTableColumnEnum.MONTH].Value);

                DetailedRevenueForm detailForm = new DetailedRevenueForm(month, year);

                detailForm.Show();
            }
        }

        private String SelectFolder()
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                return null;
            }
            else
            {
                return form.SelectedPath;
            }
        }
    }
}
