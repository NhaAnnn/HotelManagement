using System;

namespace HotelManagement.Model
{
    public class Booking
    {
        public string _id { get; set; }
        public string nameCustomer { get; set; }
        public string phone { get; set; }
        public string typeroom { get; set; }
        public decimal deposit { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
    }
}
