using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.Model
{
    internal class Hotelroom
    {
        public Guid RoomId { get; set; }
        public int RoomNum { get; set; }
        public string RoomName { get; set; }
        public Guest MainGuest { get; set; }
        public float Cost { get; set; }

        public bool IsBooked { get; set; }
        public bool IsReadyForNewGuest { get; set; }



        public Hotelroom(Guid roomId, int roomNum, string roomName, float cost, bool isBooked, bool isReadyForNewGuest)
        {
            RoomId = roomId;
            RoomNum = roomNum;
            RoomName = roomName;
            Cost = cost;
            IsBooked = isBooked;
            IsReadyForNewGuest = isReadyForNewGuest;    
        }
    }
}
