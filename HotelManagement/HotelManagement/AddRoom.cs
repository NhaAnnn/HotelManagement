using HotelManagement.Model;
using HotelManagement.Service;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class AddRoom : Form
    {
        private TypeRoomService typeRoomService = new TypeRoomService();
        private RoomService roomService = new RoomService();
        public event EventHandler RoomAdded;
        public AddRoom()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddRoom_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (CheckNull() && CheckPrice() && CheckCapa())
            {
                var newRoom = new Room
                {
                    nameRoom = txtRoomName.Text,
                    typeRoom = txtRoomType.Text,
                    capacityRoom = int.Parse(txtRooomCapa.Text),
                    priceRoom = decimal.Parse(txtRoomPrice.Text),
                    statusRoom = txtRoomSta.Text,
                    descriptionRoom = txtDescrip.Text,
                };
                await roomService.CreateRoomAsync(newRoom);

                var typeRoom = await typeRoomService.GetTypeRoomByTypeAsync(txtRoomType.Text);
                int toRoom = typeRoom.totalRoom + 1;
                var updatedTypeRoom = new TypeRoom
                {
                    typeRoom = typeRoom.typeRoom,
                    totalRoom = toRoom,
                };
                await typeRoomService.UpdateTypeRoomAsync(updatedTypeRoom);
                RoomAdded?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
           
        }

        private Boolean CheckNull()
        {
            if (txtRoomName.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Số phòng không được bỏ trống");
                return false;
            }
            if (txtRoomType.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Loại phòng không được bỏ trống");
                return false;
            }
            if (txtRooomCapa.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"Số người không được bỏ trống");
                return false;
            }
            if (txtRoomPrice.Text.IsNullOrEmpty())
            {
                MessageBox.Show($"GIá tiền không được bỏ trống");
                return false;
            }
            return true;
        }
        private Boolean CheckCapa()
        {
            try
            {
                int.Parse(txtRooomCapa.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Số người không hợp lệ");
                return false;
            }
        }
        private Boolean CheckPrice()
        {
            try
            {
                decimal.Parse(txtRoomPrice.Text);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tiền cọc không hợp lệ");
                return false;
            }
        }
        private void textBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddRoom_Click(this, EventArgs.Empty);
                e.SuppressKeyPress = true;
            }
        }
    }
    
}
