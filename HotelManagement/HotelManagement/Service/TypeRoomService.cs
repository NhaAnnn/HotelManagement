using HotelManagement.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelManagement.Service
{
    public class TypeRoomService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5215/api/TypeRoom";

        public TypeRoomService()
        {
            _httpClient = new HttpClient();
        }

        // GET: Get all Room
        public async Task<List<TypeRoom>> GetAllTypeRoomsAsync()
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);

            if (!response.IsSuccessStatusCode)
            {
                // Xử lý tình huống không có dữ liệu
                // Bạn có thể trả về một danh sách rỗng hoặc thông báo lỗi tùy ý
                return new List<TypeRoom>(); // Trả về danh sách rỗng
            }
            var typeRooms = await response.Content.ReadFromJsonAsync<List<TypeRoom>>();
            return typeRooms;
        }

        // GET: Get a room by type
        public async Task<TypeRoom> GetTypeRoomByTypeAsync(string type)
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);

            if (!response.IsSuccessStatusCode)
            {
                return null; 
            }

            var typeRooms = await response.Content.ReadFromJsonAsync<List<TypeRoom>>();

        
            var typeRoom = typeRooms
                .FirstOrDefault(b => b.typeRoom == type); 

            return typeRoom; 
        }

        // POST: Create a new rentroom
        public async Task CreateTypeRoomAsync(TypeRoom typeRoom)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, typeRoom);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var createdRoom = JsonConvert.DeserializeObject<Booking>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"Loại phòng {typeRoom.typeRoom} đã được thêm thành công");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra                  
                MessageBox.Show($"Error booking room: {ex.Message}");
            }
        }

        // PUT: Update a room
        public async Task UpdateTypeRoomAsync(TypeRoom typeRoom)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{typeRoom.typeRoom}", typeRoom);
                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<Booking>(await response.Content.ReadAsStringAsync());
                

            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error booking room: {ex.Message}");
            }
        }

        // DELETE: Delete a room
        public async Task DeleteTypeRoomAsync(string type)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{type}");
            response.EnsureSuccessStatusCode();
        }
    }
}
