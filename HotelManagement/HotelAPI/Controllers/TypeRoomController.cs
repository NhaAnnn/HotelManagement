using HotelAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HotelAPI.Controllers
{

    [Route("api/TypeRoom")]
    [ApiController]
    public class TypeRoomController : Controller
    {
   
        private string _connectionString = @"Data Source=DELL-GAMINGG3;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;";

        // GET: api/TypeRoom
        [HttpGet]
        public IActionResult GetTypeRooms()
        {
            List<TypeRoom> typeRooms = new List<TypeRoom>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TypeRoom", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            typeRooms.Add(new TypeRoom
                            {                                 
                                typeRoom = (string)reader["TypeRoom"],
                                totalRoom = (int)reader["TotalRoom"],                                  
                            });
                        }
                    }
                }
            }
            return Ok(typeRooms);
        }

        // POST: api/TypeRoom
        [HttpPost]
        public IActionResult CreateTypeRoom(TypeRoom typeRoom)
        {
            if (IsTypeRoomExists(typeRoom.typeRoom))
            {
                return Conflict($"TypeRoom with Name {typeRoom.typeRoom} already exists.");
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO TypeRoom (TypeRoom,TotalRoom) VALUES (@TypeRoom,@TotalRoom)", connection))
                {
                    command.Parameters.AddWithValue("@TypeRoom", typeRoom.typeRoom);
                    command.Parameters.AddWithValue("@TotalRoom", typeRoom.totalRoom);
                    command.ExecuteNonQuery();
                }
            }
            return CreatedAtAction("GetTypeRoom", new { name = typeRoom.typeRoom }, typeRoom);
        }

        // PUT: api/TypeRoom/A
        [HttpPut("{type}")]
        public IActionResult UpdateTypeRoom(string type, [FromBody] TypeRoom typeRoom)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE TypeRoom SET TotalRoom = @TotalRoom WHERE TypeRoom = @TypeRoom", connection))
                {                    
                    command.Parameters.AddWithValue("@TypeRoom", type);
                    command.Parameters.AddWithValue("@TotalRoom", typeRoom.totalRoom);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        // DELETE: api/TypeRoom/A
        [HttpDelete("{id}")]
        public IActionResult DeleteTypeRoom(string type)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM TypeRoom WHERE TypeRoom = @TypeRoom", connection))
                {
                    command.Parameters.AddWithValue("@TypeRoom", type);
                    command.ExecuteNonQuery();
                }
            }
            return NoContent();
        }

        private bool IsTypeRoomExists(string type)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TypeRoom WHERE TypeRoom = @TypeRoom", connection))
                {
                    command.Parameters.AddWithValue("@TypeRoom", type);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
    
}
