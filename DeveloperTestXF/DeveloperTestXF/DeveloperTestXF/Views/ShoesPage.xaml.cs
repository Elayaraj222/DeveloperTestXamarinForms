using DeveloperTestXF.ViewModels;
using System;
using Xamarin.Forms;

namespace DeveloperTestXF.Views
{
    public partial class ShoesPage : ContentPage
    {
        ShoesPageViewModel viewModel => (ShoesPageViewModel)BindingContext;
        public ShoesPage()
        {
            InitializeComponent();
        }
        //While tapping the favourite the tapped event rised 
        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            try
            {
                Shoes selectedItem = (Shoes)((Image)sender).BindingContext;
                var indexOfElement = viewModel.MyCartItems.IndexOf(selectedItem);
                if (viewModel.MyCartItems[indexOfElement].IsFavourite)
                {
                    DisplayAlert("Success", viewModel.MyCartItems[indexOfElement].ShoeName + "succcessfully added to your favourite", "Ok");
                }
                else
                {
                    DisplayAlert("Success", viewModel.MyCartItems[indexOfElement].ShoeName + "succcessfully removed from your favourite", "Ok");
                }
            }
            catch (Exception ex)
            {
                //if an error occured
                DisplayAlert("Error", "Oops! something went wrong", "Close");
            }
        }
    }
}
