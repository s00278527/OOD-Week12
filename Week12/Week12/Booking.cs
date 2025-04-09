using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    public class Booking
    {
        public int BookingID { get; set; }

        public DateTime BookingDate { get; set; }

        public int NumberOfTickets { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
