using HotelBookingApp.Core;
using HotelBookingApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private object _currentView;
        public BookingViewModel BookingVM { get; set; }

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }


        
        public ObservableCollection<NavCollectionModel> BookingNavItems { get; set; }
      

        public MainViewModel()
        {
            BookingVM = new BookingViewModel();
            CurrentView = BookingVM;




            //NavItems = new ObservableCollection<NavCollectionModel>()
            //{
            //    new NavCollectionModel("Booking", "Images/hotel (1).png", "Navigation table for bookingoptions"),
            //    new NavCollectionModel("Check In", "no image yet", "Check in panel"),
            //    new NavCollectionModel("Employee", "no image yet", "Where the emloyee can see it's work schedule, stamp in/out etc")
            //};

            //BookingNavItems = new ObservableCollection<NavCollectionModel>();

            //{
            //    new NavCollectionModel("Register new guest", "no image yet", "Register new guest form(connected to database)");
            //    new NavCollectionModel("Search for guest", "no image yet", "See guest info(incl. bookings)Edit guest info(connected to database)");
            //    new NavCollectionModel("Available rooms", "no image yet", "See available rooms(incl. bookings)(connected to database)");
               
            //};

            //CheckInNavItems = new ObservableCollection<NavCollectionModel>();

            //{
            //    new NavCollectionModel("Search for guest to check in", "no image yet", "See guest with booking and register check in");

            //};

            //EmployeeNavItems = new ObservableCollection<NavCollectionModel>();

            //{
            //    new NavCollectionModel("Stamp in/Out", "no image yet", "Register work hours(connected to database)");
            //    new NavCollectionModel("Work schedule", "no image yet", "See calendar or table with work schedule for this employee");

            //};



            //{
            //    new NavCollectionModel
            //    {
            //        Title = "Booking",
            //        ImageSource = "Images/hotel (1).png",
            //        Content = "Navigation table for bookingoptions"

            //    }
            //};



        }

    }
}
