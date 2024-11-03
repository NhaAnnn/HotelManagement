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
    public class BookingService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5215/api/Booking";

        public BookingService()
        {
            _httpClient = new HttpClient();
        }

        // GET: Get all Booking
        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);
             
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return new List<Booking>(); // Trả về danh sách rỗng
            }
            var bookings = await response.Content.ReadFromJsonAsync<List<Booking>>();
            return bookings;
        }

        // GET: Get a booking by ID
        public async Task<Booking> GetBookingByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);

            if (!response.IsSuccessStatusCode)
            {
                // Xử lý trường hợp không có dữ liệu
                return null; // Hoặc throw exception nếu cần
            }

            // Đọc danh sách đặt phòng từ phản hồi
            var bookings = await response.Content.ReadFromJsonAsync<List<Booking>>();

            // Lọc để tìm Booking tương ứng với RentRoomId
            var booking = bookings
                .FirstOrDefault(b => b._id == id); // Giả sử có thuộc tính RentRoomId trong Booking

            return booking; // Trả về đối tượng Booking hoặc null nếu không tìm thấy
        }

        // POST: Create a new booking
        public async Task CreateBookingAsync(Booking booking)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, booking);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var createdRoom = JsonConvert.DeserializeObject<Booking>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"Đơn đặt phòng mã {booking._id} đã được thêm thành công");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra                  
                 MessageBox.Show($"Error booking room: {ex.Message}");               
            }          
        }

        // PUT: Update a booking
        public async Task UpdateBookingAsync(Booking booking)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{booking._id}", booking);
                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<Booking>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"Đơn đặt phòng mã {booking._id} được cập nhật thành công");

            }
            catch (Exception ex)
            {                
                // Handle other exceptions
                MessageBox.Show($"Error booking room: {ex.Message}");                
            }
        }

        // DELETE: Delete a booking
        public async Task DeleteBookingAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{id}");
            response.EnsureSuccessStatusCode();
            MessageBox.Show($"Đơn đặt phòng mã {id} đã được xóa");
        }
    }
}
