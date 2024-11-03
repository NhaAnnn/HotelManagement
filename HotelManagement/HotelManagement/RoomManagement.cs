using HotelManagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace HotelManagement
{
    public partial class RoomManagement : Form
    {
        private RoomService _roomService = new RoomService();
        private RentRoomService _rentRoomService = new RentRoomService();

        public RoomManagement()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }
        public async void LoadRooms()
        {
            palSingleRoom.Controls.Clear();
            palDoubleRoom.Controls.Clear();
            List<Room> rooms = await _roomService.GetAllRoomsAsync();
            List<RentRoom> rentRooms = await _rentRoomService.GetAllRentRoomsAsync();

            // Tạo một danh sách để theo dõi các phòng đã được thêm
            HashSet<string> loadedRooms = new HashSet<string>();

            foreach (var room in rooms)
            {
                // Kiểm tra xem phòng đã được thêm chưa
                if (loadedRooms.Contains(room.nameRoom))
                    continue; // Bỏ qua nếu đã thêm
                
                var matchingRentRoom = rentRooms.FirstOrDefault(r => r.nameRoom == room.nameRoom);
                RoomCard card = new RoomCard(room, matchingRentRoom);
               
                if (room.typeRoom == "Phòng đơn")
                {
                    if (room.statusRoom == "Phòng trống")
                    {
                        //card.RentRoomCard(false);
                        card.LoadDataVacancy(room.nameRoom, "Phòng trống", room.statusRoom);
                    }
                    else
                    {
                        card.RentRoomCard(true);
                        card.LoadData(room.nameRoom, matchingRentRoom.customerName, room.statusRoom, matchingRentRoom.checkIn, matchingRentRoom.checkOut);
                    }
                    card.Margin = new Padding(50, 10, 10, 10);
                    palSingleRoom.Controls.Add(card);
                }
                else if (room.typeRoom == "Phòng đôi")
                {
                    if (room.statusRoom == "Phòng trống")
                    {
                        card.RentRoomCard(false);
                        card.LoadDataVacancy(room.nameRoom, "Phòng trống", room.statusRoom);
                    }
                    else
                    {
                        card.RentRoomCard(true);
                        card.LoadData(room.nameRoom, matchingRentRoom.customerName, room.statusRoom, matchingRentRoom.checkIn, matchingRentRoom.checkOut);
                    }
                    card.Margin = new Padding(50, 10, 10, 10);
                    palDoubleRoom.Controls.Add(card);
                }

                // Thêm tên phòng vào danh sách đã tải
                loadedRooms.Add(room.nameRoom);
            }
        }


        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.RoomAdded += (s, args) => LoadRooms();
            addRoom.ShowDialog();
           
        }

        private async void ChangeStatus(string name, string status)
        {
           
            await _roomService.UpdateStatusRoomAsync(name, status);
        }
    }
}
