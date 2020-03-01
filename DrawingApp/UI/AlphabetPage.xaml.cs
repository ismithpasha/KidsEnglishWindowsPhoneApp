using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.BackgroundAudio;
using Microsoft.Xna.Framework.Media;

namespace DrawingApp
{
    public partial class AlphabetPage : PhoneApplicationPage
    {
        public AlphabetPage()
        {
            InitializeComponent();

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button myButton = sender as Button;

            string imgUrl = myButton.Tag.ToString(); 

            NavigationService.Navigate(new Uri("/UI/ViewImage.xaml?imgUrl="+imgUrl, UriKind.Relative));

        }
    }
}