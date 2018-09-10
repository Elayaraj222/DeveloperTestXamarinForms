using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Collections.ObjectModel;

namespace DeveloperTestXF.ViewModels
{
    public class ShoesPageViewModel : ViewModelBase
    {
        //Dummy data
        private List<Shoes> _cartItems = new List<Shoes>();
        public ShoesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Shoes";
            //DefaultText = "This page must be implemented";
            _cartItems.Add(new Shoes
            {
                ShoeImage = "Princes_shoe.png",
                ShoeName = "Princes Shoes",
                SubTitle = "Perfect",
                Distance = "5 KM",
                IsFavourite = false
            });
            _cartItems.Add(new Shoes
            {
                ShoeImage = "nice_snekers.png",
                ShoeName = "Nice Sneakers",
                SubTitle = "Light Used",
                Distance = "1 KM",
                IsFavourite = true
            });
            _cartItems.Add(new Shoes
            {
                ShoeImage = "shoe_light.png",
                ShoeName = "Shoe With Light",
                SubTitle = "New",
                Distance = "5 KM",
                IsFavourite = false
            });
            _cartItems.Add(new Shoes
            {
                ShoeImage = "classic.png",
                ShoeName = "Classic Vans",
                SubTitle = "Used",
                Distance = "3 KM",
                IsFavourite = true
            });
            _cartItems.Add(new Shoes
            {
                ShoeImage = "ballarine.png",
                ShoeName = "Ballarine Shoe",
                SubTitle = "Used",
                Distance = "4 KM",
                IsFavourite = false
            });
            _cartItems.Add(new Shoes
            {
                ShoeImage = "black_snekers.png",
                ShoeName = "Black Sneakers",
                SubTitle = "Heavy Used",
                Distance = "2.5 KM",
                IsFavourite = false
            });
            MyCartItems = new ObservableCollection<Shoes>(_cartItems);
        }
        private ObservableCollection<Shoes> _myCartItems = new ObservableCollection<Shoes>();
        public ObservableCollection<Shoes> MyCartItems
        {
            get { return _myCartItems; }
            set
            {
                SetProperty(ref _myCartItems, value);
                RaisePropertyChanged("MyCartItems");
            }
        }
        private string defaultText;
        public string DefaultText
        {
            get { return defaultText; }
            set { SetProperty(ref defaultText, value); }
        }
    }
}
