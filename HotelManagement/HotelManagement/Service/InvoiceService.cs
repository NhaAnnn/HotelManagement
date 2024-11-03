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
    public class InvoiceService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl = "http://localhost:5215/api/Invoice";

        public InvoiceService()
        {
            _httpClient = new HttpClient();
        }

        // GET: Get all Room
        public async Task<List<Invoice>> GetAllInvoicesAsync()
        {
            var response = await _httpClient.GetAsync(_apiBaseUrl);
            // Check for successful response        
            if (!response.IsSuccessStatusCode)
            {
                // Xử lý tình huống không có dữ liệu
                // Bạn có thể trả về một danh sách rỗng hoặc thông báo lỗi tùy ý
                return new List<Invoice>(); // Trả về danh sách rỗng
            }
            var invoices = await response.Content.ReadFromJsonAsync<List<Invoice>>();
            return invoices;
        }

        // GET: Get a room by ID
        public async Task<Invoice> GeInvoiceByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Invoice>();
        }

        // POST: Create a new rentroom
        public async Task CreateInvoiceAsync(Invoice invoice)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(_apiBaseUrl, invoice);

                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var createdRoom = JsonConvert.DeserializeObject<Invoice>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"Hóa đơn {invoice._id} đã được lưu thành công");
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi có thể xảy ra                  
                MessageBox.Show($"Error invoice created: {ex.Message}");
            }
        }

        // PUT: Update a room
        public async Task UpdateInvoiceAsync(Invoice invoices)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/{invoices._id}", invoices);
                // Kiểm tra xem request có thành công không
                response.EnsureSuccessStatusCode();

                // Deserialize dữ liệu phản hồi từ server
                var updatedRoom = JsonConvert.DeserializeObject<Invoice>(await response.Content.ReadAsStringAsync());
                MessageBox.Show($"Hóa đơn {invoices._id} được cập nhật thành công");

            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show($"Error invoice: {ex.Message}");
            }
        }

        // DELETE: Delete a room
        public async Task DeleteBookingAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"{_apiBaseUrl}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
