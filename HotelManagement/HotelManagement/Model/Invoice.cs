using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Model
{
    public class Invoice
    {
        public string _id { get; set; }
        public string nameCustomer { get; set; }
        public string nameroom { get; set; }
        public string typeroom { get; set; }
        public DateTime invoiceDate { get; set; }
        public int countDate { get; set; }
        public decimal totalCost { get; set; }
    }
}
