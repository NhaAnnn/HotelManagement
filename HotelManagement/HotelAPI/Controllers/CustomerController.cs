using HotelAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HotelAPI.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private string _connectionString = @"Data Source=DELL-GAMINGG3;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        // GET: api/Customer
        [HttpGet]
        public IActionResult GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                nameCustomer = (string)reader["CustomerName"],
                                cccd = (string)reader["CCCD"],
                                phone = (string)reader["Phone"],                              
                            });
                        }
                    }
                }
            }
            return Ok(customers);
        }


        // GET: api/Customer/A
        [HttpGet("{name}")]
        public IActionResult GetCustomer(string name)
        {
            Customer customer = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerName = @CustomerName", connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customer
                            {
                                nameCustomer = (string)reader["CustomerName"],
                                cccd = (string)reader["CCCD"],
                                phone = (string)reader["Phone"],
                            };
                        }
                    }
                }
            }
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST: api/Customer
        [HttpPost]
        public IActionResult CreateRoom(Customer customer)
        {
            if (IsCustomerExists(customer.cccd))
            {
                 return NoContent();
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Customer (CustomerName, CCCD, Phone) VALUES (@CustomerName, @CCCD, @Phone)", connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customer.nameCustomer);
                    command.Parameters.AddWithValue("@CCCD", customer.cccd);
                    command.Parameters.AddWithValue("@Phone", customer.phone);
                    command.ExecuteNonQuery();
                }
            }
            return CreatedAtAction("GetCustomer", new { name = customer.nameCustomer }, customer);
        }

        // PUT: api/Customer/A
        [HttpPut("{name}")]
        public IActionResult UpdateRoom(string cccd, [FromBody] Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Customer SET CustomerName = @CustomerName, Phone = @Phone WHERE CCCD = @CCCD", connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", customer.nameCustomer);                
                    command.Parameters.AddWithValue("@Phone", customer.phone);
                    command.Parameters.AddWithValue("@CCCD", cccd);
                    command.ExecuteNonQuery();
                }
            }

            return NoContent();
        }

        // DELETE: api/Customer/A
        [HttpDelete("{name}")]
        public IActionResult DeleteRoom(string cccd)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE CCCD = @CCCD", connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", cccd);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        private bool IsCustomerExists(string cccd)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Customer WHERE CCCD = @CCCD", connection))
                {
                    command.Parameters.AddWithValue("@CCCD", cccd);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
