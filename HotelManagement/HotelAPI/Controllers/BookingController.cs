using HotelAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HotelAPI.Controllers
{
    [Route("api/Booking")]
    [ApiController]
    public class BookingController : Controller
    {
        private string _connectionString = @"Data Source=DELL-GAMINGG3;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        // GET: api/Booking
        [HttpGet]
        public IActionResult GetBookings()
        {
            List<Booking> bookings = new List<Booking>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Booking", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookings.Add(new Booking
                            {
                                _id = (string)reader["ID"],
                                nameCustomer = (string)reader["CustomerName"],
                                typeroom = (string)reader["TypeRoom"],
                                phone = (string)reader["Phone"],
                                deposit = (decimal)reader["Deposit"],
                                checkIn = (DateTime)reader["CheckInDate"],
                                checkOut = (DateTime)reader["CheckOutDate"],
                            });
                        }
                    }
                }
            }
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(string id)
        {
            Booking booking = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Booking WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            booking = new Booking
                            {
                                _id = (string)reader["ID"],
                                nameCustomer = (string)reader["CustomerName"],
                                typeroom = (string)reader["TypeRoom"],
                                phone = (string)reader["Phone"],
                                deposit = (decimal)reader["Deposit"],
                                checkIn = (DateTime)reader["CheckInDate"],
                                checkOut = (DateTime)reader["CheckOutDate"],
                            };
                        }
                    }
                }
            }
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }

        // POST: api/Booking
        [HttpPost]
        public IActionResult CreateBooking(Booking booking)
        {
            if (IsBookingExists(booking._id))
            {
                return Conflict($"Booking with ID {booking._id} already exists.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Booking (ID ,CustomerName, Phone, TypeRoom, Deposit, CheckInDate, CheckOutDate) VALUES (@ID, @CustomerName, @Phone, @TypeRoom, @Deposit, @CheckInDate, @CheckOutDate)", connection))
                {
                    command.Parameters.AddWithValue("@ID", booking._id);
                    command.Parameters.AddWithValue("@CustomerName", booking.nameCustomer);
                    command.Parameters.AddWithValue("@Phone", booking.phone);
                    command.Parameters.AddWithValue("@TypeRoom", booking.typeroom);
                    command.Parameters.AddWithValue("@Deposit", booking.deposit);
                    command.Parameters.AddWithValue("@CheckInDate", booking.checkIn);
                    command.Parameters.AddWithValue("@CheckOutDate", booking.checkOut);
                    command.ExecuteNonQuery();
                }
            }
            return CreatedAtAction("GetBooking", new { id = booking._id }, booking);
        }

        // PUT: api/Booking/A
        [HttpPut("{id}")]
        public IActionResult UpdateBooking(string id, [FromBody] Booking booking)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Booking SET CustomerName = @CustomerName, Phone = @Phone, TypeRoom = @TypeRoom, Deposit = @Deposit, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("ID", id);
                    command.Parameters.AddWithValue("@CustomerName", booking.nameCustomer);
                    command.Parameters.AddWithValue("@Phone", booking.phone);
                    command.Parameters.AddWithValue("TypeRoom", booking.typeroom);
                    command.Parameters.AddWithValue("@Deposit", booking.deposit);
                    command.Parameters.AddWithValue("CheckInDate", booking.checkIn);
                    command.Parameters.AddWithValue("CheckOutDate", booking.checkOut);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        // DELETE: api/Booking/A
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Booking WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        private bool IsBookingExists(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Booking WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
