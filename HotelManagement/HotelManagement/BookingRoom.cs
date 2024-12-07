using HotelManagement.Model;
using HotelManagement.Service;
using Microsoft.IdentityModel.Tokens;
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
                txtDateIn.Value = DateTime.Parse(row.Cells[5].Value?.ToString());
                txtDateOut.Value = DateTime.Parse(row.Cells[6].Value?.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            EnableText(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            EnableText(true);
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
            
            txtName.ReadOnly = a;
            txtPhone.ReadOnly = a;
            txtType.ReadOnly = a;
            txtDeposit.ReadOnly = a;
            txtDateIn.Enabled = !a;
            txtDateOut.Enabled = !a;
        }
        private Boolean CheckNull()
        {
            if (txtName.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Tên Khách hàng không được bỏ trống");
                return false;
            }
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"SĐT Khách hàng không được bỏ trống");
                return false;
            }
            if (txtType.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Loại phòng không được bỏ trống");
                return false;
            }
            if (txtDeposit.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Tiền cọc không được bỏ trống");
                return false;
            }
            return true;
        }
        private Boolean CheckDate()
        {
            if (txtDateIn.Value == DateTime.Now)
            {
                MessageBox.Show($"Không thể đặt phòng với ngày nhận phòng là ngày hôm nay");
                return false;
            }
            if (txtDateIn.Value >= txtDateOut.Value)
            {
                MessageBox.Show($"Ngày không hợp lệ");
                return false;
            }
            return true;
        }
        private Boolean CheckPrice()
        {
            try
            {
                decimal.Parse(txtDeposit.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tiền cọc không hợp lệ");
                return false;
            }
        }
    }
}