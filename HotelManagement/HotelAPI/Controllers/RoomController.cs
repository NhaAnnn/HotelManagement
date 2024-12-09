using HotelAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HotelAPI.Controllers
{
    [Route("api/Room")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private string _connectionString = @"Data Source=DELL-GAMINGG3;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        // GET: api/Room
        [HttpGet]
        public IActionResult GetRooms()
        {
            List<Room> rooms = new List<Room>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Room", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new Room
                            {
                                nameRoom = (string)reader["NameRoom"],
                                typeRoom = (string)reader["TypeRoom"],
                                capacityRoom = (int)reader["CapacityRoom"],
                                priceRoom = (decimal)reader["PriceRoom"],
                                statusRoom = (string)reader["StatusRoom"],
                                descriptionRoom = (string)reader["DescriptionRoom"]
                            });
                        }
                    }
                }
            }
            return Ok(rooms);
        }


        // GET: api/Room/101
        [HttpGet("{name}")]
        public IActionResult GetRoom(string name)
        {
            Room room = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE NameRoom = @NameRoom", connection))
                {
                    command.Parameters.AddWithValue("@NameRoom", name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            room = new Room
                            {
                                nameRoom = (string)reader["NameRoom"],
                                typeRoom = (string)reader["TypeRoom"],
                                capacityRoom = (int)reader["CapacityRoom"],
                                priceRoom = (decimal)reader["PriceRoom"],
                                statusRoom = (string)reader["StatusRoom"],
                                descriptionRoom = (string)reader["DescriptionRoom"]

                            };
                        }
                    }
                }
            }
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        // GET: api/Room/Available
        [HttpPut("{nameRoom}/{status}")]
        public IActionResult SetRoomAvailable(string nameRoom, string status)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Room SET StatusRoom = @StatusRoom WHERE NameRoom = @NameRoom", connection))
                {
                    command.Parameters.AddWithValue("@StatusRoom", status);                  
                    command.Parameters.AddWithValue("@NameRoom", nameRoom);
                    command.ExecuteNonQuery();
                    
                }
            }
            return NoContent();
        }

        // POST: api/Room
        [HttpPost]
        public IActionResult CreateRoom(Room room)
        {
            if (IsRoomExists(room.nameRoom))
            {
                return Conflict($"Room with Name {room.nameRoom} already exists.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Room (NameRoom, TypeRoom, CapacityRoom, PriceRoom, StatusRoom, DescriptionRoom) VALUES (@NameRoom, @TypeRoom, @CapacityRoom, @PriceRoom, @StatusRoom, @DescriptionRoom)", connection))
                {
                    command.Parameters.AddWithValue("@NameRoom", room.nameRoom);
                    command.Parameters.AddWithValue("@TypeRoom", room.typeRoom);
                    command.Parameters.AddWithValue("@CapacityRoom", room.capacityRoom);
                    command.Parameters.AddWithValue("@PriceRoom", room.priceRoom);
                    command.Parameters.AddWithValue("@StatusRoom", room.statusRoom);
                    command.Parameters.AddWithValue("@DescriptionRoom", room.descriptionRoom);
                    command.ExecuteNonQuery();
                }
            }
            return CreatedAtAction("GetRoom", new { name = room.nameRoom }, room);
        }

        // PUT: api/Room/101
        [HttpPut("{name}")]
        public IActionResult UpdateRoom(string name,[FromBody] Room room)
        {           
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Room SET TypeRoom = @TypeRoom, CapacityRoom = @CapacityRoom, PriceRoom = @PriceRoom, StatusRoom = @StatusRoom, DescriptionRoom = @DescriptionRoom WHERE NameRoom = @NameRoom", connection))
                {
                    command.Parameters.AddWithValue("@TypeRoom", room.typeRoom);
                    command.Parameters.AddWithValue("@CapacityRoom", room.capacityRoom);
                    command.Parameters.AddWithValue("@PriceRoom", room.priceRoom);
                    command.Parameters.AddWithValue("@StatusRoom", room.statusRoom);
                    command.Parameters.AddWithValue("@DescriptionRoom", room.descriptionRoom);
                    command.Parameters.AddWithValue("@NameRoom", name);
                    command.ExecuteNonQuery();                 
                }
            }

            return NoContent(); 
        }

        // DELETE: api/Room/101
        [HttpDelete("{name}")]
        public IActionResult DeleteRoom(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Room WHERE NameRoom = @NameRoom", connection))
                {
                    command.Parameters.AddWithValue("@NameRoom", name);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        private bool IsRoomExists(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Room WHERE NameRoom = @NameRoom", connection))
                {
                    command.Parameters.AddWithValue("@NameRoom", name);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}