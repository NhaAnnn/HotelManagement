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
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5215/api/Customer";

        public CustomerService()
        {
            _httpClient = new HttpClient();
        }

        // GET: Get all Room
        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);

            if (!response.IsSuccessStatusCode)
            {
                // Xử lý tình huống không có dữ liệu
                // Bạn có thể trả về một danh sách rỗng hoặc thông báo lỗi tùy ý
                return new List<Customer>(); // Trả về danh sách rỗng
            }
            var customers = await response.Content.ReadFromJsonAsync<List<Customer>>();
            return customers;
        }

        // GET: Get a room by ID
        public async Task<Customer> GetCustomerByIdAsync(string name)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{name}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Customer>();
        }

        // POST: Create a new room
        public async Task CreateCustomerAsync(Customer customer)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, customer);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var createdRoom = JsonConvert.DeserializeObject<Customer>(await response.Content.ReadAsStringAsync());
                //MessageBox.Show($"Khách hàng {customer.nameCustomer} đã được thêm thành công");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra
                MessageBox.Show($"Error creating room: {ex.Message}");
                
            }
        }

        // PUT: Update a room
        public async Task UpdateCustomerAsync(Customer customer)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{customer.nameCustomer}", customer);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<Customer>(await response.Content.ReadAsStringAsync());
                //MessageBox.Show($"Phòng {room.nameRoom} đã được cập nhật thành công");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra                   
                MessageBox.Show($"Error updating room: {ex.Message}");
            }
        }

        // DELETE: Delete a room
        public async Task DeleteCustomerAsync(string name)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{name}");
            response.EnsureSuccessStatusCode();
            MessageBox.Show($"Khách hàng {name} đã được xóa thành công");
        }
    }
}
