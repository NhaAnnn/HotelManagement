using HotelManagement.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class RoomCard : UserControl
    {
        private Room room { get; set; }
        private RentRoom rentRoom { get; set; }
        public RoomCard(Room room, RentRoom rentRoom)
        {
            InitializeComponent();
            this.room = room;
            this.rentRoom = rentRoom;
        }
        public void LoadData(string name, string CustomerName, string status, DateTime checkin, DateTime checkout)
        {
            labNameRoom.Text = name;
            labStatusRoom.Text = status;
            labCustomer.Text = CustomerName;
            CheckInDate.Text = checkin.Date.ToString("MM/dd/yyyy");
            CheckOutDate.Text = checkout.Date.ToString("MM/dd/yyyy");

        }
        public void LoadDataVacancy(string name, string CustomerName, string status)
        {
            labNameRoom.Text = name;
            labStatusRoom.Text = status;
            labCustomer.Text = CustomerName;
            CheckInDate.Visible = false;
            CheckOutDate.Visible = false;

        }
        private void RoomCard_Click(object sender, EventArgs e)
        {
            if (labStatusRoom.Text == "Phòng trống")
            {
                /*RentRoom rentRoom = new RentRoom
                {
                    _id = Guid.NewGuid().ToString(),
                    nameRoom = labNameRoom.Text,
                    customerName = labCustomer.Text,
                    checkIn = CheckInDate.Value,
                    checkOut = CheckOutDate.Value,

                };*/

                RoomDetail dialogForm = new RoomDetail(room);
                dialogForm.RoomChanged += (s, args) =>
                {
                    // Gọi LoadRooms() để tải lại tất cả dữ liệu
                    var parentForm = this.FindForm() as RoomManagement;
                    parentForm?.LoadRooms();
                };

                dialogForm.ShowDialog();
            }
            else
            {
                Payment payment = new Payment(rentRoom);
                payment.RoomChanged += (s, args) =>
                {
                    var thisCard = this;
                    thisCard.RentRoomCard(false);
                    var parentForm = this.FindForm() as RoomManagement;
                    parentForm?.LoadRooms();
                };
                payment.ShowDialog();
            }
        }
        public void RentRoomCard(Boolean isRental)
        {
            if (isRental)
            {
                palBackgroundCard.BackColor = Color.LightSeaGreen;
                CheckInDate.Visible = true;
                CheckOutDate.Visible = true;
                picCard.Image = Properties.Resources.icons8_customer_50;
            }
            else
            {
                palBackgroundCard.BackColor = Color.ForestGreen;
                CheckInDate.Visible = false;
                CheckOutDate.Visible = false;
                picCard.Image = Properties.Resources.icons8_check_50;
            }

        }
    }
}



