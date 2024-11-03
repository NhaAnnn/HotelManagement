namespace HotelAPI.Model
{
    public class RentRoom
    {
        public string _id { get; set; }
        public string nameRoom { get; set; }
        public string typeRoom { get; set; }
        public string customerName { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public decimal price { get; set; }
        public string bookingid { get; set; }
    }
}
