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
    internal class MainViewModel
    {

        public ObservableCollection<NavCollectionModel> NavItem;

        public MainViewModel()
        {
            NavItem = new ObservableCollection<NavCollectionModel>();

            {
                new NavCollectionModel("Booking", "Images/hotel (1).png", "Navigation table for bookingoptions");
                new NavCollectionModel("Check In", "no image yet", "Check in panel");
                new NavCollectionModel("Employee", "no image yet", "Where the emloyee can see it's work schedule, stamp in/out etc");
            };
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
