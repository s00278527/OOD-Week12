using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12
{
    public class MovieData : DbContext
    {
        public MovieData() : base("OODExam_UxueSaezFernandez") { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
