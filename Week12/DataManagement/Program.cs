using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week12;

namespace DataManagement
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            MovieData db = new MovieData();

            using(db)
            {
                Movie m1 = new Movie() 
                {
                    Title= "The Banshees of Inisherin", 
                    ImageName = "Images/BansheesInisherin.jpg", 
                    Cast = "Colin Farrell, Brendan Gleeson, Kerry Condon, Barry Keoghan", 
                    Description = "The Banshees of Inisherin is a 2022 black tragicomedy film directed by Martin McDonagh. Set on a remote, fictional island off the west coast of Ireland in 1923, the film stars Colin Farrell and Brendan Gleeson as two lifelong friends who find themselves at an impasse when one abruptly ends their relationship, with severe consequences for both of them. The movie explores the anguish and gravity of their breakup in a world where men don't usually express their feelings."
                };
                Movie m2 = new Movie()
                {
                    Title = "Aftersun",
                    ImageName = "Images/Aftersun.jpg",
                    Cast = "Paul Mescal, Frankie Corio, Celia Rowlson-Hall, Sally Messham",
                    Description = "Aftersun is a 2022 semi-autobiographical coming-of-age drama film written and directed by Charlotte Wells in her feature directorial debut. Starring Paul Mescal, Frankie Corio, and Celia Rowlson-Hall, the film is loosely based on Wells' childhood and follows an 11-year-old Scottish girl on holiday with her father at a Turkish resort on the eve of his 31st birthday."
                };
                Movie m3 = new Movie()
                {
                    Title = "The Quiet Girl",
                    ImageName = "Images/QuietGuirl.jpg",
                    Cast = "Carrie Crowley, Andrew Bennett, Catherine Clinch",
                    Description = "The Quiet Girl is a 2022 Irish coming-of-age drama film written and directed by Colm Bairéad, in his feature film debut.[1][2] Based on the 2010 short story \"Foster\" by Claire Keegan, it stars Catherine Clinch, Carrie Crowley and Andrew Bennett."
                };

                db.Movies.Add(m1);
                db.Movies.Add(m2);
                db.Movies.Add(m3);

                Booking b1 = new Booking() { BookingDate = new DateTime(2025,07,10), Movie = m1, NumberOfTickets = 2 };
                Booking b2 = new Booking() { BookingDate = new DateTime(2025, 07, 10), Movie = m1, NumberOfTickets = 6 };
                Booking b3 = new Booking() { BookingDate = new DateTime(2025, 04, 09), Movie = m2, NumberOfTickets = 3 };
                Booking b4 = new Booking() { BookingDate = new DateTime(2025, 04, 10), Movie = m3, NumberOfTickets = 2 };

                db.Bookings.Add(b1);
                db.Bookings.Add(b2);
                db.Bookings.Add(b3);
                db.Bookings.Add(b4);

                db.SaveChanges();
                Console.WriteLine("Data base created");
            }
        }
    }
}
