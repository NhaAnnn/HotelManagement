using HotelAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace HotelAPI.Controllers
{
    [Route("api/RentRoom")]
    [ApiController]
    public class RentRoomController : Controller
    {
        private string _connectionString = @"Data Source=DELL-GAMINGG3;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        // GET: api/RentRoom
        [HttpGet]
        public IActionResult GetRentRooms()
        {
            try
            {
                List<RentRoom> rentRooms = new List<RentRoom>();
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM RentRoom", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rentRooms.Add(new RentRoom
                                {
                                    _id = (string)reader["ID"],
                                    nameRoom = (string)reader["NameRoom"],
                                    typeRoom = (string)reader["TypeRoom"],
                                    customerName = (string)reader["CustomerName"],
                                    checkIn = (DateTime)reader["CheckInDate"],
                                    checkOut = (DateTime)reader["CheckOutDate"],
                                    price = (decimal)reader["Price"],
                                    bookingid = (string)reader["BookingID"],
                                });
                            }
                        }
                    }
                }
                if (rentRooms.Count == 0)
                {
                    return NotFound("No rent rooms found.");
                }
                return Ok(rentRooms);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

       

        // GET: api/RentRoom/101
        [HttpGet("{id}")]
        public IActionResult GetRentRoom(string id)
        {
            RentRoom rentRoom = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM RentRoom WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentRoom = new RentRoom
                            {
                                _id = (string)reader["ID"],
                                nameRoom = (string)reader["NameRoom"],
                                typeRoom = (string)reader["TypeRoom"],
                                customerName = (string)reader["CustomerName"],
                                checkIn = (DateTime)reader["CheckInDate"],
                                checkOut = (DateTime)reader["CheckOutDate"],
                                price = (decimal)reader["Price"],
                                bookingid = (string)reader["BookingID"],
                            };
                        }
                    }
                }
            }
            if (rentRoom == null)
            {
                return NotFound();
            }
            return Ok(rentRoom);
        }



        // POST: api/RentRoom
        [HttpPost]
        public IActionResult CreateRentRoom(RentRoom rentRoom)
        {
            if (IsRentRoomExists(rentRoom._id))
            {
                return Conflict($"Room with Name {rentRoom.nameRoom} already exists.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO RentRoom (ID ,NameRoom, TypeRoom, CustomerName, CheckInDate, CheckOutDate, Price, BookingID) VALUES (@ID, @NameRoom, @TypeRoom, @CustomerName, @CheckInDate, @CheckOutDate, @Price, @BookingID)", connection))
                {
                    command.Parameters.AddWithValue("@ID", rentRoom._id);
                    command.Parameters.AddWithValue("@NameRoom", rentRoom.nameRoom);
                    command.Parameters.AddWithValue("@TypeRoom", rentRoom.typeRoom);
                    command.Parameters.AddWithValue("@CustomerName", rentRoom.customerName);
                    command.Parameters.AddWithValue("@CheckInDate", rentRoom.checkIn);
                    command.Parameters.AddWithValue("@CheckOutDate", rentRoom.checkOut);
                    command.Parameters.AddWithValue("@Price", rentRoom.price);
                    command.Parameters.AddWithValue("@BookingID", rentRoom.bookingid);
                    command.ExecuteNonQuery();
                }
            }   
            return CreatedAtAction("GetRentRoom", new { id = rentRoom._id }, rentRoom);
        }

        // PUT: api/RentRoom/101
        [HttpPut("{id}")]
        public IActionResult UpdateRentRoom(string id, RentRoom rentRoom)
        {
            if (id != rentRoom._id)
            {
                return BadRequest();
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE RentRoom SET NameRoom = @NameRoom, TypeRoom = @TypeRoom, CustomerName = @CustomerName, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, Price = @, BookingID = @BookingID WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@NameRoom", rentRoom.nameRoom);
                    command.Parameters.AddWithValue("@TypeRoom", rentRoom.typeRoom);
                    command.Parameters.AddWithValue("@CustomerName", rentRoom.customerName);
                    command.Parameters.AddWithValue("@CheckInDate", rentRoom.checkIn);
                    command.Parameters.AddWithValue("@CheckOutDate", rentRoom.checkOut);
                    command.Parameters.AddWithValue("@Price", rentRoom.price);
                    command.Parameters.AddWithValue("@BookingID", rentRoom.bookingid);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        // DELETE: api/RentRoom/101
        [HttpDelete("{name}")]
        public IActionResult DeleteRentRoom(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM RentRoom WHERE NameRoom = @NameRoom", connection))
                {
                    command.Parameters.AddWithValue("@NameRoom", name);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        private bool IsRentRoomExists(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM RentRoom WHERE ID = @ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }   
    }
}
