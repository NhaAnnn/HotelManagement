using HotelManagement.Model;
using HotelManagement.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class RoomDetail : Form
    {
        public event EventHandler RoomChanged;
        

        private RentRoomService rentRoomService = new RentRoomService();
        private RoomService roomService = new RoomService();
        private CustomerService customerService = new CustomerService();
        private TypeRoomService typeRoomService = new TypeRoomService();
        private RentRoom newRRoom = new RentRoom();
        private Room room = new Room();
        private static Random random = new Random();

        public static string GenerateRentRoomCode()
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
        public RoomDetail(Room room)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.room = room;
            txtName.Text = room.nameRoom.ToString();
            txtType.Text = room.typeRoom.ToString();
            txtCapacity.Text = room.capacityRoom.ToString();
            txtPrice.Text = room.priceRoom.ToString();
            txtStatus.Text = room.statusRoom.ToString();
         
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            var updatedRoom = new Room
            {
                nameRoom = txtName.Text.ToString(),
                typeRoom = txtType.Text.ToString(),
                capacityRoom = int.Parse(txtCapacity.Text),
                priceRoom = decimal.Parse(txtPrice.Text),
                statusRoom = txtStatus.Text,
            };            
            await roomService.UpdateRoomAsync(updatedRoom);
            MessageBox.Show($"Phòng {room.nameRoom} đã được cập nhật thành công");      
            RoomChanged?.Invoke(this, EventArgs.Empty);
            EnableText(false);       
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            EnableText(false);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            await roomService.DeleteRoomAsync(room.nameRoom.ToString());

            var typeRoom = await typeRoomService.GetTypeRoomByTypeAsync(txtType.Text);
            int toRoom = typeRoom.totalRoom - 1;
            var updatedTypeRoom = new TypeRoom
            {
                typeRoom = typeRoom.typeRoom,
                totalRoom = toRoom,
            };
            await typeRoomService.UpdateTypeRoomAsync(updatedTypeRoom);
            RoomChanged?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            this.Close();
        }
       
        private async void btnRent_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (CheckNull() && CheckDate())
            {
                var newRentRoom = new RentRoom
                {
                    _id = GenerateRentRoomCode().ToString(),
                    nameRoom = txtName.Text,
                    typeRoom = txtType.Text,
                    customerName = txtCusName.Text,
                    checkIn = checkInDate.Value,
                    checkOut = checkOutDate.Value,
                    price = room.priceRoom,
                    bookingid = txtBookingID.Text,
                };
                await rentRoomService.CreateRentRoomAsync(newRentRoom);

                var newCustomer = new Customer
                {
                    cccd = txtCusCCCD.Text,
                    nameCustomer = txtCusName.Text,
                    phone = txtSDT.Text,
                };
                await customerService.CreateCustomerAsync(newCustomer);

                /*var updatedRoom = new Room
                {
                    nameRoom = txtName.Text.ToString(),
                    typeRoom = txtType.Text.ToString(),
                    capacityRoom = int.Parse(txtCapacity.Text),
                    priceRoom = decimal.Parse(txtPrice.Text),
                    statusRoom = "Đã thuê",
                };*/
                await roomService.UpdateStatusRoomAsync(txtName.Text,"Đã thuê");

                MessageBox.Show($"Phòng {room.nameRoom} đã được thuê thành công");
                
                RoomChanged?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
           
        }
        private void EnableText(Boolean a)
        {
            txtType.ReadOnly = a;
            txtCapacity.ReadOnly = a;
            txtPrice.ReadOnly = a;
        }
       
        private Boolean CheckNull()
        {

            if (txtCusName.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Tên Khách hàng không được bỏ trống");
                return false;
            }
            if (txtCusCCCD.Text.IsNullOrEmpty())               
            {
                MessageBox.Show($"CCCD Khách hàng không được bỏ trống");
                return false;
            }
            if (txtSDT.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"SĐT Khách hàng không được bỏ trống");
                return false;
            }         
            return true;
        }

        private Boolean CheckDate()
        {
            if (checkInDate.Value >= checkOutDate.Value)
            {
                MessageBox.Show($"Ngày không hợp lệ");
                return false;
            }
            return true;
        }
    }
}
