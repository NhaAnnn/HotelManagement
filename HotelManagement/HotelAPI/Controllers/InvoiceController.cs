using HotelAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HotelAPI.Controllers
{
    [Route("api/Invoice")]
    [ApiController]
    public class InvoiceController : Controller
    {
        private string _connectionString = @"Data Source=DELL-GAMINGG3;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        // GET: api/Invoice
        [HttpGet]
        public IActionResult GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Invoice", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            invoices.Add(new Invoice
                            {
                                _id = (string)reader["ID"],
                                nameCustomer = (string)reader["CustomerName"],
                                nameroom = (string)reader["NameRoom"],
                                typeroom = (string)reader["TypeRoom"],
                                invoiceDate = (DateTime)reader["InvoiceDate"],
                                countDate = (int)reader["CountDate"],
                                totalCost = (decimal)reader["TotalCost"],
                            });
                        }
                    }
                }
            }
            return Ok(invoices);
        }

        [HttpGet("{id}")]
        public IActionResult GetInvoice(string id)
        {
            Invoice invoice = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Invoice WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            invoice = new Invoice
                            {
                                _id = (string)reader["ID"],
                                nameCustomer = (string)reader["CustomerName"],
                                nameroom = (string)reader["NameRoom"],
                                typeroom = (string)reader["TypeRoom"],
                                invoiceDate = (DateTime)reader["InvoiceDate"],
                                countDate = (int)reader["CountDate"],
                                totalCost = (decimal)reader["TotalCost"],
                            };
                        }
                    }
                }
            }
            if(invoice != null)
            {
                return NotFound();
            }
            return Ok(invoice);
        }

        // POST: api/Invoice
        [HttpPost]
        public IActionResult CreateInvoice(Invoice invoice)
        {
            if (IsInvoiceExists(invoice._id))
            {
                return Conflict($"Invoice with ID {invoice._id} already exists.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Invoice (ID ,CustomerName, NameRoom, TypeRoom, InvoiceDate, CountDate, TotalCost) VALUES (@ID, @CustomerName, @NameRoom, @TypeRoom, @InvoiceDate, @CountDate, @TotalCost)", connection))
                {
                    command.Parameters.AddWithValue("@ID", invoice._id);    
                    command.Parameters.AddWithValue("@CustomerName", invoice.nameCustomer);
                    command.Parameters.AddWithValue("@NameRoom", invoice.nameroom);
                    command.Parameters.AddWithValue("@TypeRoom", invoice.typeroom);
                    command.Parameters.AddWithValue("@InvoiceDate", invoice.invoiceDate);
                    command.Parameters.AddWithValue("@CountDate", invoice.countDate);
                    command.Parameters.AddWithValue("@TotalCost", invoice.totalCost);
                    command.ExecuteNonQuery();
                }
            }
            return CreatedAtAction("GetInvoice", new { id = invoice._id }, invoice);
        }

        // PUT: api/Invoice/A
        [HttpPut("{id}")]
        public IActionResult UpdateInvoice(string id, [FromBody] Invoice invoice)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Invoice SET CustomerName = @CustomerName, NameRoom = @NameRoom, TypeRoom = @TypeRoom, InvoiceDate = @InvoiceDate, CountDate = @CountDate, TotalCost = @TotalCost WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@CustomerName", invoice.nameCustomer);
                    command.Parameters.AddWithValue("@NameRoom", invoice.nameroom);
                    command.Parameters.AddWithValue("@TypeRoom", invoice.typeroom);
                    command.Parameters.AddWithValue("@InvoiceDate", invoice.invoiceDate);
                    command.Parameters.AddWithValue("@CountDate", invoice.countDate);
                    command.Parameters.AddWithValue("@TotalCost", invoice.totalCost);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        // DELETE: api/Invoice/A
        [HttpDelete("{id}")]
        public IActionResult DeleteInvoice(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Invoice WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        private bool IsInvoiceExists(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Invoice WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
