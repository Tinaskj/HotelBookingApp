using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.Model
{
    internal class Guest
    {
        public string Name { get; set; }
        public Guid GuestId { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string GuestInfo { get; set; }

        public bool IsCheckedIn { get; set; }

        //public string GuestStatus { get; set; }
        //public string Category { get; set; }

        public List<Hotelroom> RoomBooked { get; set; }
        

        public Guest(string name, Guid guestId, string adress, string phoneNumber, string email,  string guestInfo, bool isCheckedIn)
        {
            Name = name;
            GuestId = guestId;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Email = email;
            GuestInfo = guestInfo;
            IsCheckedIn = isCheckedIn;
            //Category = category;
            RoomBooked = new List<Hotelroom>();
        }
    }
}
