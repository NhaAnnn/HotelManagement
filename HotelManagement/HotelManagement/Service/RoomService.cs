using HotelManagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManagement
{
    public class RoomService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5215/api/Room";

        public RoomService()
        {
            _httpClient = new HttpClient();
        }

        // GET: Get all Room
        public async Task<List<Room>> GetAllRoomsAsync()
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);
           
            if (!response.IsSuccessStatusCode)
            {
                // Xử lý tình huống không có dữ liệu
                // Bạn có thể trả về một danh sách rỗng hoặc thông báo lỗi tùy ý
                return new List<Room>(); // Trả về danh sách rỗng
            }
            var rooms = await response.Content.ReadFromJsonAsync<List<Room>>();
            return rooms;
        }

        // GET: Get a room by ID
        public async Task<Room> GetRoomByIdAsync(string name)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{name}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Room>();
        }

        // POST: Create a new room
        public async Task CreateRoomAsync(Room room)
        {
            try
            {              
                var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, room);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var createdRoom = JsonConvert.DeserializeObject<Room>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"Phòng {room.nameRoom} đã được thêm thành công");              
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra
                if (ex.Message.Contains("409"))
                {
                    // Handle the conflict error, e.g., display a custom error message
                    MessageBox.Show($"Lỗi: Phòng đã tồn tại");
                }
                else
                {
                    // Handle other exceptions
                    MessageBox.Show($"Error creating room: {ex.Message}");
                }
            }         
        }

        // PUT: Update a room
        public async Task UpdateRoomAsync(Room room)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{room.nameRoom}", room);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<Room>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra                   
                MessageBox.Show($"Error updating room: {ex.Message}");
            }
        }

        // PUT: Update status room
        public async Task UpdateStatusRoomAsync(string name, string status)
        {
            try
            {
                var updated = await _httpClient.GetAsync($"{_apiBaseUrl}/{name})");

                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{name}/{status}", updated);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<Room>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra                   
                MessageBox.Show($"Error updating room: {ex.Message}");
            }
        }

        // DELETE: Delete a room
        public async Task DeleteRoomAsync(string name)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{name}");
            response.EnsureSuccessStatusCode();
            MessageBox.Show($"Phòng {name} đã được xóa thành công");
        }
    }
}
