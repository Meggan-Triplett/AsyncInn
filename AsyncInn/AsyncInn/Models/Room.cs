using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Layout { get; set; }

        public ICollection<RoomAmenities> RoomAmenities { get; set; }
        public ICollection<HotelRoom> HotelRooms { get; set; }
    }

    public enum Layouts
    {
        Studio = 0,
        OneBedroom = 1,
        TwoBedroom = 2,
        Suite = 3,
        Penthouse = 4
    }
}
