using HotelBookingApp.Core;
using HotelBookingApp.MVVM.Model;
using HotelBookingApp.MVVM.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.ViewModel
{
    internal class BookingViewModel : ObservableObject
    {

        public ObservableCollection<BookingModel> Bookings;
        public ObservableCollection<Guest> Guests;
        public ObservableCollection<Hotelroom> Hotelrooms;

        public BookingModel SelectedBooking { get; set; }

        public Hotelroom RoomBooked { get; set; }

        public string GetStatus()
        {
            if (DateTime.Today < CheckInDate)
                return "Reserved";

            if (DateTime.Today > CheckOutDate)
                return "Checked out";

            return "Checked In";
        }
        public int GetDays()
        {
            return (CheckOutDate - CheckInDate).Days;
        }

        public float GetCostPerDay(Hotelroom room)
        {
            return room.Cost;
        }

        public float GetTotal(Hotelroom room)
        {
            return room.Cost * GetDays();
        }

        //public string GetGuestStatus()
        //{
        //    if()
        //}

        public BookingViewModel()
        {
            Bookings.Add(new BookingModel(Guid.NewGuid(), );
           
            Guests.Add(new Guest("Guest One", Guid.NewGuid(), "Gueststreet 1", "98765432", "guest1@email.com", "Guest info shows here", false));
            Guests.Add(new Guest("Guest Two", Guid.NewGuid(), "Gueststreet 2", "12345678", "guest2@email.com", "Guest info shows here", false));

            Hotelrooms.Add(new Hotelroom(Guid.NewGuid(), 101, "Double Room Standard", 143, false, true));
                
            //    = new List<Guest>()
            //{
            //    new Guest("Guest One", Guid.NewGuid(), "Gueststreet 1", "98765432", "gueast@email.com", "Guest info shows here", false)
            //};

            

        }


    }
}
