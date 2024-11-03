using HotelManagement.Model;
using HotelManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class BookingRoom : Form
    {
        private BookingService bookingService = new BookingService();
        public BookingRoom()
        {
            InitializeComponent();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.BookingAdded += (s, args) => LoadBooking();
            addBooking.ShowDialog();
        }

        private void BookingRoom_Load(object sender, EventArgs e)
        {
            LoadBooking();
        }

        private async void LoadBooking(string filter = null)
        {
           
            daGridView.Controls.Clear();
            List<Booking> bookings = await bookingService.GetAllBookingsAsync();

            // Filter bookings if a filter is provided
            if (!string.IsNullOrEmpty(filter))
            {
                bookings = bookings.Where(b => b._id.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0
                || b.nameCustomer.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0
                || b.phone.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0
                || b.typeroom.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

                daGridView.DataSource = bookings;

                daGridView.Columns[0].HeaderText = "Mã";
                daGridView.Columns[1].HeaderText = "Tên khách hàng";
                daGridView.Columns[2].HeaderText = "Số điện thoại";
                daGridView.Columns[3].HeaderText = "Loại phòng";
                daGridView.Columns[4].HeaderText = "Tiền cọc";
                daGridView.Columns[5].HeaderText = "Ngày nhận phòng";
                daGridView.Columns[6].HeaderText = "Ngày trả phòng";
            }

            if (bookings.Any())
            {
                daGridView.DataSource = bookings;

                daGridView.Columns[0].HeaderText = "Mã";
                daGridView.Columns[1].HeaderText = "Tên khách hàng";
                daGridView.Columns[2].HeaderText = "Số điện thoại";
                daGridView.Columns[3].HeaderText = "Loại phòng";
                daGridView.Columns[4].HeaderText = "Tiền cọc";
                daGridView.Columns[5].HeaderText = "Ngày nhận phòng";
                daGridView.Columns[6].HeaderText = "Ngày trả phòng";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            LoadBooking(searchText);
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
                txtDeposit.Text = row.Cells[4].Value?.ToString();
                txtDateIn.Text = row.Cells[5].Value?.ToString();
                txtDateOut.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableText(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableText(false);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var booking = new Booking
            {
                _id = txtID.Text,
                nameCustomer = txtName.Text,
                phone = txtPhone.Text,
                typeroom = txtType.Text,
                deposit = decimal.Parse(txtDeposit.Text),
                checkIn = DateTime.Parse(txtDateIn.Text),
                checkOut = DateTime.Parse(txtDateOut.Text)
            };
            await bookingService.UpdateBookingAsync(booking);
            //MessageBox.Show($"Đơn đặt phòng mã {txtID.Text} đã được cập nhật");
            LoadBooking();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa booking này không?",
                                         "Xác nhận xóa",
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);

            if (confirmResult == DialogResult.OK)
            {
                await bookingService.DeleteBookingAsync(txtID.Text);
                LoadBooking();
            }

        }

        private void EnableText(Boolean a)
        {
            txtID.ReadOnly = a;
            txtName.ReadOnly = a;
            txtPhone.ReadOnly = a;
            txtType.ReadOnly = a;
            txtDeposit.ReadOnly = a;
            txtDateIn.ReadOnly = a;
            txtDateOut.ReadOnly = a;
        }
    }
}