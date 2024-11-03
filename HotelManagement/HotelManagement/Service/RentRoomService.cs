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
    public class RentRoomService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5215/api/RentRoom";

        public RentRoomService()
        {
            _httpClient = new HttpClient();
        }

        // GET: Get all Room
        public async Task<List<RentRoom>> GetAllRentRoomsAsync()
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);
            
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return new List<RentRoom>(); // Return an empty list or handle as needed
            }
            var rentRooms = await response.Content.ReadFromJsonAsync<List<RentRoom>>();
            return rentRooms;
        }

        // GET: Get a room by ID
        public async Task<RentRoom> GetRentRoomByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<RentRoom>();
        }

        // POST: Create a new rentroom
        /* public async Task CreateRentRoomAsync(RentRoom rentRoom)
         {
             try
             {
                 var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, rentRoom);

                 // Kiểm tra xem request có thành công không
                 response.EnsureSuccessStatusCode();

                 // Deserialize dữ liệu phản hồi từ server
                 var createdRentRoom = JsonConvert.DeserializeObject<RentRoom>(await response.Content.ReadAsStringAsync());

                 MessageBox.Show($"A room name {rentRoom.nameRoom} has been created successfully");
             }
             catch (Exception ex)
             {
                // Xử lý các lỗi có thể xảy ra                
                 MessageBox.Show($"Error creating room: {ex.Message}");
             }

         }*/
        public async Task CreateRentRoomAsync(RentRoom rentRoom)
        {
            try
            {
                var json = JsonConvert.SerializeObject(rentRoom);
                Console.WriteLine($"Request JSON: {json}");

                var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, rentRoom);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Deserialize response
                var createdRentRoom = JsonConvert.DeserializeObject<RentRoom>(await response.Content.ReadAsStringAsync());

                
            }
            catch (HttpRequestException httpEx)
            {
                
                MessageBox.Show($"HTTP error: {httpEx.Message}");
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show($"JSON error: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        // PUT: Update a room
        public async Task UpdateRentRoomAsyncRentRoom(RentRoom rentRoom)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{rentRoom._id}", rentRoom);
                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<RentRoom>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"A room name {rentRoom.nameRoom} has been updated successfully");

            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra
                MessageBox.Show($"Error creating room: {ex.Message}");
            }
        }

        // DELETE: Delete a room
        public async Task DeleteRentRoomAsync(string name)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{name}");
            response.EnsureSuccessStatusCode();
        }
    }
}
