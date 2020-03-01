using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DrawingApp.Resources;

namespace DrawingApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

           
        //    mediaElement.Play();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

       


        private void page1Button_Click(object sender, RoutedEventArgs e)
        {

           NavigationService.Navigate(new Uri("/UI/Page1.xaml", UriKind.Relative));
           
          
        }

        private void page2Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UI/AlphabetPage.xaml", UriKind.Relative));
        }

        private void ArtPageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UI/ArtPage.xaml", UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}