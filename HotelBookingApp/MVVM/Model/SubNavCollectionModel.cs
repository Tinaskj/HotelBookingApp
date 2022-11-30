using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.MVVM.Model
{
    internal class SubNavCollectionModel
    {
        public string Name;
        public string ImageSource;
        public string Content;

        public SubNavCollectionModel(string name, string imageSource, string content)
        {
            Name = name;
            ImageSource = imageSource;
            Content = content;
        }
    }
}
