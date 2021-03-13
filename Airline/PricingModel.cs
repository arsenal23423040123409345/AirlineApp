using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
        class PricingModel
        {
                FlightDetail flight { get; set; }
                AirlineDbEntities db;
                public void setPrice()
                {
                        db = new AirlineDbEntities();
                        var cnt = (from o in db.Bookings
                                   select o.SeatNo).Count();

                        if ((120 - cnt) >= 100)
                        {
                                flight.FlightCharges -= 5;                               
                        }
                        else if ((120 - cnt) > 50 && (120 - cnt) < 100)
                        {
                            flight.FlightCharges -= 8;
                        }
                        else if ((120 - cnt) <= 50)
                        {
                            flight.FlightCharges -= 9;
                        }
                }
         }
 }

