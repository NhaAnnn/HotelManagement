using HotelManagement.Model;
using HotelManagement.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class AddBooking : Form
    {
        public event EventHandler BookingAdded;
        public BookingService bookingService = new BookingService();
        private RoomService roomService = new RoomService();
        private RentRoomService rentRoomService = new RentRoomService();
        private TypeRoomService typeRoomService = new TypeRoomService();
        public AddBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private static Random random = new Random();

        public static string GenerateBookingCode()
        {
            // Tạo chuỗi ký tự
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const int length = 8; // Độ dài mã đặt phòng

            // Tạo mã ngẫu nhiên
            char[] bookingCode = new char[length];
            for (int i = 0; i < length; i++)
            {
                bookingCode[i] = chars[random.Next(chars.Length)];
            }

            return new string(bookingCode);
        }
        private async void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            List<RentRoom> rentRooms = await rentRoomService.GetAllRentRoomsAsync();
            if (CheckNull() && CheckPrice() && CheckDate())
            {
                var newBooking = new Booking()
                {
                    _id = GenerateBookingCode().ToString(),
                    nameCustomer = txtCusName.Text,
                    phone = txtPhone.Text,
                    typeroom = txtRoomType.Text,
                    deposit = decimal.Parse(txtDeposit.Text),
                    checkIn = checkIn.Value,
                    checkOut = checkOut.Value,
                };
                if(await CanCreateReservationAsync(newBooking))
                {
                    await bookingService.CreateBookingAsync(newBooking);
                    BookingAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
               
            }
        }            

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.Close();
        }

        private Boolean CheckNull()
        {
            if (txtCusName.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Tên Khách hàng không được bỏ trống");
                return false;
            }
            if (txtPhone.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"SĐT Khách hàng không được bỏ trống");
                return false;
            }
            if (txtRoomType.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Loại phòng không được bỏ trống");
                return false;
            }
            if( txtDeposit.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Tiền cọc không được bỏ trống");
                return false;
            }
            return true;
        }
        private Boolean CheckDate()
        {
            if(checkIn.Value == DateTime.Now)
            {
                MessageBox.Show($"Không thể đặt phòng với ngày nhận phòng là ngày hôm nay");
                return false;
            }
            if (checkIn.Value >= checkOut.Value)
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
            }catch (Exception ex)
            {
                MessageBox.Show($"Tiền cọc không hợp lệ");
                return false;
            }
        }

        public async Task<bool> CanCreateReservationAsync(Booking newBooking)
        {
            var bookings = await bookingService.GetAllBookingsAsync();
            var typeRoom = await typeRoomService.GetTypeRoomByTypeAsync(newBooking.typeroom);

            int  totalRooms = 0;

            foreach (var booking in bookings)
            {
                // Kiểm tra xem khoảng thời gian kiểm tra có xung đột với đặt phòng không
                if (newBooking.checkIn < booking.checkOut && newBooking.checkOut > booking.checkIn)
                {
                    // Cộng số phòng đã đặt
                    totalRooms++;
                }
            }
            if(totalRooms >= typeRoom.totalRoom) 
            {
                MessageBox.Show($"Loại phòng được đặt không còn phong trống tại thời điểm này");
                return false;
            }

            return true;
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddBooking_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
}
