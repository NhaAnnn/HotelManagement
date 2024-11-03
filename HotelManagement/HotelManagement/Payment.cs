using Amazon.Runtime.Documents;
using HotelManagement.Model;
using HotelManagement.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Xml.Linq;
using MessageBox = System.Windows.MessageBox;
using System.Drawing.Imaging;
using System.IO;

namespace HotelManagement
{
    public partial class Payment : Form
    {
        public event EventHandler RoomChanged;

        private RoomService roomService = new RoomService();
        private BookingService BookingService = new BookingService();
        private RentRoomService RentRoomService = new RentRoomService();
        private InvoiceService InvoiceService = new InvoiceService();
        private RentRoom rentRoom {  get; set; }
        private static Random random = new Random();
        private PrintDocument printDocument;

        public Payment(RentRoom rentRoom)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            printDocument = new PrintDocument();
            this.rentRoom = rentRoom;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public async void LoadData()
        {
            Booking booking = await BookingService.GetBookingByIdAsync(rentRoom.bookingid);
            txtInvoiceId.Text = GenerateInvoiceCode().ToString();
            txtCusName.Text = rentRoom.customerName;
            txtNameRoom.Text = rentRoom.nameRoom;
            txtTypeRoom.Text = rentRoom.typeRoom;
            txtInvoiceDate.Text = DateTime.Now.ToString();
            txtCost.Text = rentRoom.price.ToString();
            txtBookingID.Text = rentRoom.bookingid;

            DateTime dateIn = rentRoom.checkIn.Date;
            DateTime dateOut = rentRoom.checkOut.Date;

            decimal totalAmount;
            decimal sum;
            int day = (dateOut - dateIn).Days;
            Debug.WriteLine(day.ToString());
            txtCountDate.Text = day.ToString();
            
            sum = rentRoom.price * day * 1000;
            txtSumCost.Text = sum.ToString("N0") + " VNĐ";
            if (booking != null) 
            {              
                txtDeposit.Text = booking.deposit.ToString();
                // Tính toán tổng tiền
                totalAmount = ((rentRoom.price * day) - booking.deposit) * 1000;

                // Định dạng số với dấu phẩy ở mỗi 1000
                txtTotal.Text = totalAmount.ToString("N0") + " đồng"; // "N0" cho định dạng số nguyên
            }
            else
            {
                txtDeposit.Text = "0";
                // Tính toán tổng tiền
                totalAmount = (rentRoom.price * day * 1000);

                // Định dạng số với dấu phẩy ở mỗi 1000
                txtTotal.Text = totalAmount.ToString("N0") + " đồng"; // "N0" cho định dạng số nguyên
            }

            txtCostDetail.Text = "( " + ConvertToWords(int.Parse(totalAmount.ToString())) + " đồng )";
        }
        public static string ConvertToWords(int number)
        {
            if (number == 0) return "không";

            string[] units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] thousands = { "", "nghìn", "triệu", "tỷ" };

            string words = "";
            int unitIndex = 0;

            while (number > 0)
            {
                int part = number % 1000;
                if (part > 0)
                {
                    words = GetHundreds(part, units, tens) + " " + thousands[unitIndex] + " " + words;
                }
                number /= 1000;
                unitIndex++;
            }

            return CapitalizeFirstLetter(words.Trim());
        }

        private static string GetHundreds(int number, string[] units, string[] tens)
        {
            string result = "";

            if (number >= 100)
            {
                result += units[number / 100] + " trăm ";
                number %= 100;
            }
            if (number >= 10)
            {
                result += tens[number / 10];
                number %= 10;

                if (number > 0)
                {
                    result += " ";
                }
            }
            if (number > 0)
            {
                result += (number == 5 && result.Length > 0) ? "lăm " : units[number] + " ";
            }

            return result.Trim();
        }

        private static string CapitalizeFirstLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            await roomService.UpdateStatusRoomAsync(txtNameRoom.Text, "Phòng trống");
            RoomChanged?.Invoke(this, EventArgs.Empty);

            await RentRoomService.DeleteRentRoomAsync(rentRoom.nameRoom);
            var newInvoice = new Invoice
            {
                 _id = txtInvoiceId.Text,
                 nameCustomer = txtCusName.Text,
                 nameroom = txtNameRoom.Text,
                 typeroom = txtTypeRoom.Text,
                 invoiceDate = DateTime.Now,
                 countDate = int.Parse(txtCountDate.Text),
                 totalCost = rentRoom.price * int.Parse(txtCountDate.Text) * 1000,
            };
            await InvoiceService.CreateInvoiceAsync(newInvoice);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.Close();
        }

        public static string GenerateInvoiceCode()
        {
            // Tạo chuỗi ký tự
            const string chars = "0123456789";
            const int length = 8; // Độ dài mã đặt phòng

            // Tạo mã ngẫu nhiên
            char[] bookingCode = new char[length];
            for (int i = 0; i < length; i++)
            {
                bookingCode[i] = chars[random.Next(chars.Length)];
            }

            return new string(bookingCode);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Ẩn tất cả các nút
            btnPrint.Visible = false;
            btnClose.Visible = false;
            btnPayment.Visible = false;
            panel1.Visible = false;

            // Tạo một đối tượng PrintDocument
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Tạo một đối tượng PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            // Nếu người dùng bấm "OK" trong hộp thoại In
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
               
                // In giao diện của Form
                printDocument.Print();
                MessageBox.Show("Đã in hóa đơn thành công");
            }

            // Hiện lại các nút sau khi in
            btnPrint.Visible = true;
            btnClose.Visible = true;
            btnPayment.Visible = true;
            panel1.Visible = true;

        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Tạo một bitmap từ giao diện của Form
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Calculate position to center the image
            int x = (e.PageBounds.Width - bitmap.Width) / 2;
            

            e.Graphics.DrawImage(bitmap, x, 0);
        }
    }
}
