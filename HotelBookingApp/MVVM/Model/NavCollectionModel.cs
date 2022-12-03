using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.Model
{
    internal class NavCollectionModel
    {
        public string Title;
        public string ImageSource;
        public string Content;
        public ObservableCollection<NavCollectionModel> BookingNavItems;
        public ObservableCollection<NavCollectionModel> CheckInNavItems;
        public ObservableCollection<NavCollectionModel> EmployeeNavItems;


        public NavCollectionModel(string title, string imageSource, string content)
        {
            Title = title;
            ImageSource = imageSource;
            Content = content;
        }

        public override string ToString()
        {
            return Title;
        }

    }
}
