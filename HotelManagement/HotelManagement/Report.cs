using HotelManagement.Model;
using HotelManagement.Service;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Report : Form
    {
        private InvoiceService invoiceService = new InvoiceService();
        public Report()
        {
            InitializeComponent();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            LoadInvoice();
        }
        private async void LoadInvoice( string filter = null)
        {
            daGridView.Controls.Clear();
            cbMonth.Items.Clear();
            List<Invoice> invoices = await invoiceService.GetAllInvoicesAsync();

            cbMonth.Items.Add($"Tất cả");
            for (int month = 1; month <= 12; month++)
            {
                cbMonth.Items.Add($"Tháng {month}");
            }

            if (!string.IsNullOrEmpty(filter))
            {
                daGridView.DataSource = invoices;

                daGridView.Columns[0].HeaderText = "Mã";
                daGridView.Columns[1].HeaderText = "Tên khách hàng";
                daGridView.Columns[2].HeaderText = "Số phòng";
                daGridView.Columns[3].HeaderText = "Loại phòng";    
                daGridView.Columns[5].HeaderText = "Ngày lập hóa đơn";
                daGridView.Columns[4].HeaderText = "Số ngày ở";
                daGridView.Columns[6].HeaderText = "Số tiền đã thanh toán";
            }

            if(invoices.Any())
            {
                daGridView.DataSource = invoices;

                daGridView.Columns[0].HeaderText = "Mã";
                daGridView.Columns[1].HeaderText = "Tên khách hàng";
                daGridView.Columns[2].HeaderText = "Số phòng";
                daGridView.Columns[3].HeaderText = "Loại phòng";
                daGridView.Columns[5].HeaderText = "Số ngày ở";
                daGridView.Columns[4].HeaderText = "Ngày lập hóa đơn";
                daGridView.Columns[6].HeaderText = "Số tiền đã thanh toán";
            }

            decimal total = 0;
            foreach (DataGridViewRow row in daGridView.Rows)
            {
                // Lấy giá trị của cột theo tên
                var value = row.Cells[6].Value;
                if (value != null && decimal.TryParse(value.ToString(), out decimal number))
                {
                    total += number; // Cộng dồn vào tổng
                }
            }
            txtTotal.Text = total.ToString("N0") + " đồng";
        }
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (daGridView.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên trong danh sách hàng được chọn
                DataGridViewRow row = daGridView.SelectedRows[0];

                // Hiển thị thông tin trong TextBox
                txtID.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtPhone.Text = row.Cells[2].Value?.ToString();
                txtType.Text = row.Cells[3].Value?.ToString();
                txtDateCnt.Text = row.Cells[4].Value?.ToString();
                txtDate.Text = row.Cells[5].Value?.ToString();
                txtMoney.Text = row.Cells[6].Value?.ToString();
            }
        }
        private void ExportToExcel(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                sfd.Title = "Save an Excel File Report";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.Visible = false; // Không hiển thị Excel khi lưu
                    Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                    // Xuất tiêu đề
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                    }

                    // Xuất dữ liệu
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Lưu file
                    workbook.SaveAs(sfd.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    // Giải phóng bộ nhớ
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel(daGridView);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tháng đã chọn
            int selectedMonth = cbMonth.SelectedIndex;
            if(selectedMonth == 0)
            {
                LoadInvoice(); 
            }
            // Gọi hàm lọc dữ liệu
            else FilterDataByMonth(selectedMonth);
        }

        private async void FilterDataByMonth(int month)
        {
            // Giả sử bạn có một danh sách dữ liệu hóa đơn
            List<Invoice> allInvoices = await invoiceService.GetAllInvoicesAsync();

            // Lọc hóa đơn theo tháng
            var filteredInvoices = allInvoices.Where(invoice =>
                invoice.invoiceDate.Month == month
            ).ToList();

            // Cập nhật DataGridView
            daGridView.DataSource = filteredInvoices;

            decimal total = 0;
            foreach (DataGridViewRow row in daGridView.Rows)
            {
                // Lấy giá trị của cột theo tên
                var value = row.Cells[6].Value;
                if (value != null && decimal.TryParse(value.ToString(), out decimal number))
                {
                    total += number; // Cộng dồn vào tổng
                }
            }
            txtTotal.Text = total.ToString("N0") + " đồng";
        }
    }
}
