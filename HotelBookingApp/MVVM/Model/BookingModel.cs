using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.Model
{
    internal class BookingModel
    {

        
        public ObservableCollection<Guest> Guests;
        public ObservableCollection<Hotelroom> Hotelrooms;

        public Guid BookingId { get; set; }
        public Guest GuestBooked { get; set; }
        public Hotelroom RoomBooked { get; set; }
        public string Status { get; set; }
        //{
        //    get
        //    {
        //        if (DateTime.Today < CheckInDate)
        //            return "Reserved";

        //        if (DateTime.Today > CheckOutDate)
        //            return "Checked out";

        //        return "Checked In";
        //    }
        //}

        

        public int Days { get; set; }
        public float DailyCost { get; set; }
        public float TotalCost { get; set; }

        public BookingModel()
        {

        }
 
        public BookingModel(string status, int days, float dailyCost, float totalCost)
        {
            BookingId= Guid.NewGuid();
            Status = status;
            Days = days;
            DailyCost = dailyCost;
            TotalCost = totalCost;
        }

        //public string Title { get; set; }
        //public string ImageSource { get; set; }


        //// - Guest -> Register new guest, edit guest info, search for guest
        //// - Rooms -> See available rooms (calendar), new booking, cancel booking, edit booking.

        //public BookingModel(string title, string imageSource)
        //{
        //    Title= title;  
        //    ImageSource= imageSource;
        //}



    }
}
